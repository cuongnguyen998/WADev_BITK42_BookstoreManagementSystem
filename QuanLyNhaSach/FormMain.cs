using DevExpress.XtraBars;
#pragma warning disable CS0246 // The type or namespace name 'QLNS_BusinessAccessLayer' could not be found (are you missing a using directive or an assembly reference?)
using QLNS_BusinessAccessLayer;
#pragma warning restore CS0246 // The type or namespace name 'QLNS_BusinessAccessLayer' could not be found (are you missing a using directive or an assembly reference?)
using QLNS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace QuanLyNhaSach
{

    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        private Accounts _loginAccount;

        public Accounts LoginAccount { get => _loginAccount; set { _loginAccount = value; isAdminAccount(_loginAccount.Role); } }
        public FormMain(Accounts account)
        {
            InitializeComponent();
            this.LoginAccount = account;
            GetMaxBillId();
            ShowBillDetail(Convert.ToInt32(txtbBillNum.Text));
        }

        #region Methods
        //Chức năng thanh toán hóa đơn
        void CheckOut()
        {
            int idBill = Convert.ToInt32(txtbBillNum.Text);
            decimal discount = nmDiscount.Value;
            decimal totalPrice = decimal.Parse(txtbTotalPrice.Text.Split(',')[0]);
            decimal finalTotalPrice = totalPrice - totalPrice / 100 * discount;
            if (MessageBox.Show(String.Format("Bạn có muốn thanh toán hóa đơn số {0}. Tổng tiền - Tổng tiền / 100 * Giảm giá = {1} - {1}/100*{2} = {3}", idBill, txtbTotalPrice.Text, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                BillDAO.Instance.CheckOut(idBill, discount, finalTotalPrice);
                NewBill();
            }
        }
        //Chức năng Thêm hóa đơn và thêm sách vào trong hóa đơn
        void AddBookIntoBillDetail()
        {
            int idBill = Convert.ToInt32(txtbBillNum.Text);
            string idCustomer = txtbCustomerId.Text;
            string bookCode = txbBookCode.Text;
            int idBook = BooksDAO.Instance.GetBookIdByBookCode(bookCode);
            int amount = (int)nmAmount.Value;
            AddBillDetail(idBill, idCustomer, idBook, amount);
            ShowBillDetail(idBill);
        }
        void AddBillDetail(int idBill, string idCustomer, int idBook, int amount)
        {
            lsvBill.Items.Clear();
            if (!BillDAO.Instance.IsExistBill(idBill))
            {
                BillDAO.Instance.InsertBill(idCustomer);
                BillDetailDAO.Instance.InsertBillDetail(idBill, idBook, amount);
            }
            else
            {
                BillDetailDAO.Instance.InsertBillDetail(idBill, idBook, amount);
            }
        }
        void GetMaxBillId()
        {
            int idBill = BillDAO.Instance.GetMaxBillId();
            string idCustomer = BillDAO.Instance.GetCustomerIdByBillId(idBill);
            txtbBillNum.Text = idBill.ToString();
            txtbCustomerId.Text = idCustomer;
        }
        void NewBill()
        {
            int idBill = BillDAO.Instance.GetMaxBillId() + 1;
            txtbBillNum.Text = idBill.ToString();
            //txtbBillNum.Text = (Convert.ToInt32(txtbBillNum.Text) + 1).ToString();
            //int idBill = Convert.ToInt32(txtbBillNum.Text);
            ShowBillDetail(idBill);
        }
        void ShowBillDetail(int idBill)
        {
            lsvBill.Items.Clear();
            List<Menus> listMenus = MenuDAO.Instance.GetListMenuByBillId(idBill);
            decimal totalPrice = 0;
            foreach (Menus item in listMenus)
            {
                ListViewItem listItem = new ListViewItem(item.BookName.ToString());
                listItem.SubItems.Add(item.Amount.ToString());
                listItem.SubItems.Add(item.UnitPrice.ToString());
                listItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(listItem);
            }
            //Chuyển culture về VN để format tiền
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;

            txtbTotalPrice.Text = totalPrice.ToString("c");

        }
        void isAdminAccount(int role)
        {
            if (role != 2)
            {
                btnAccountSetting.Enabled = false;
                btnCustomer.Enabled = false;
                btnBooks.Enabled = false;
                btnBookCategory.Enabled = false;
                btnSupplier.Enabled = false;
                btnServer.Enabled = false;
                btnInventoryReport.Enabled = false;
                btnRevenueReport.Enabled = false;
            }
            btnAccountInfo.Caption += " (" + LoginAccount.DisplayName+")";
        }


        #endregion

        #region Events
       
        private void Form_UpdateAccount(object sender, AccountEvent e)
        {
            btnAccountInfo.Caption = "Thông tin tài khoản (" + e.Account.DisplayName + ")";
        }

        private void btnAccountInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            AccountInfoForm form = new AccountInfoForm(LoginAccount);
            form.UpdateAccount += Form_UpdateAccount;
            form.ShowDialog();
        }
        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookIntoBillDetail();
        }
        private void btnNewBill_Click(object sender, EventArgs e)
        {
            NewBill();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut();
        }
        private void btnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCustomer form = new FormCustomer();
            form.ShowDialog();
        }

        private void btnBookCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormBookCategory form = new FormBookCategory();
            form.ShowDialog();
        }

        private void btnBooks_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormBook form = new FormBook();
            form.ShowDialog();
        }

        private void btnSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormSupplier form = new FormSupplier();
            form.ShowDialog();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                NewBill();
            }
            else if (e.KeyCode == Keys.C && e.Control)
            {
                CheckOut();
            }
            else if (e.KeyCode == Keys.X && e.Control)
            {
                AddBookIntoBillDetail();
            }
        }
        private void btnHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHelp form = new FormHelp();
            form.ShowDialog();
        }

        private void btnAccountSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormAccountSetting form = new FormAccountSetting();
            form.ShowDialog();
        }

        private void btnInput_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormInput form = new FormInput();
            form.ShowDialog();
        }
        #endregion


    }
}