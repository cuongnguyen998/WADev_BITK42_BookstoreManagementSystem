using DevExpress.XtraEditors;
using QLNS_BusinessAccessLayer;
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
namespace QuanLyNhaSach
{
    public partial class FormInput : DevExpress.XtraEditors.XtraForm
    {
        BindingSource listInput = new BindingSource();
        BindingSource listInputDetail = new BindingSource();
        public FormInput()
        {
            InitializeComponent();
            LoadAll();
        }

        #region Methods
        bool UpdateBookWhenInsertInputDetail(int idBook, int idSupplier, int amount, decimal unitPrice)
        {
            return BooksDAO.Instance.UpdateBookWhenInsertInputDetail(idBook, idSupplier, amount, unitPrice);
            
        }
        bool AddNewInputDetail(int idBook, int amount, string idInput, decimal inputPrice, decimal outputPrice)
        {
            return InputDetailDAO.Instance.InsertInputDetail(idBook, amount, idInput, outputPrice, inputPrice);
        }
        bool AddNewInput(string inputId, DateTime dateInput, int idSupplier)
        {
            return InputDAO.Instance.InsertInput(inputId, dateInput, idSupplier);
        }
        void LoadAll()
        {
            gvInput.GridControl.DataSource = listInput;
            gvInputDetail.GridControl.DataSource = listInputDetail;
            LoadInputList();
            LoadLookUpEditSupllier(lkpSupplier);
            LoadLookUpEditCategory(lkpCategory);
            InputBinding();
            InputDetailBinding();

        }
        void InputDetailBinding()
        {
            txtbBookName.DataBindings.Add(new Binding("Text", gctrlInputDetail.DataSource, "Tên sách", true, DataSourceUpdateMode.Never));
            txtbInputPrice.DataBindings.Add(new Binding("Text", gctrlInputDetail.DataSource, "Giá nhập", true, DataSourceUpdateMode.Never));
            txtbOutputPrice.DataBindings.Add(new Binding("Text", gctrlInputDetail.DataSource, "Giá bìa", true, DataSourceUpdateMode.Never));
            nmAmount.DataBindings.Add(new Binding("Value", gctrlInputDetail.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
            lkpCategory.DataBindings.Add(new Binding("EditValue", gctrlInputDetail.DataSource, "Danh mục", true, DataSourceUpdateMode.Never));
        }
        void InputBinding()
        {
            txtbInputId.DataBindings.Add(new Binding("Text", gctrlInput.DataSource, "Mã PN", true, DataSourceUpdateMode.Never));
            dtpkInputDate.DataBindings.Add(new Binding("Value", gctrlInput.DataSource, "Ngày nhập", true, DataSourceUpdateMode.Never));
            lkpSupplier.DataBindings.Add(new Binding("EditValue", gctrlInput.DataSource, "Tên NCC", true, DataSourceUpdateMode.Never));
        }
        void LoadLookUpEditCategory(LookUpEdit lookUpEdit)
        {
            lookUpEdit.Properties.DataSource = BookCategoryDAO.Instance.GetListCategory();
            lookUpEdit.Properties.DisplayMember = "Tên danh mục";
            lookUpEdit.Properties.ValueMember = "Mã danh mục";
        }
        void LoadLookUpEditSupllier(LookUpEdit lookUpEdit)
        {
            lookUpEdit.Properties.DataSource = SuppliersDAO.Instance.LoadListSupplier();
            lookUpEdit.Properties.DisplayMember = "Tên NCC";
            lookUpEdit.Properties.ValueMember = "Mã NCC";
        }

        void LoadInputList()
        {
            listInput.DataSource = InputDAO.Instance.LoadInputList();

        }
        void LoadInputDetailList(string idInput)
        {
            listInputDetail.DataSource = InputDetailDAO.Instance.LoadInputDetailByInputId(idInput);
        }
        #endregion


        #region Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string idInput = txtbInputId.Text;
            int idSupplier = Convert.ToInt32(lkpSupplier.EditValue);
            int idBook = BooksDAO.Instance.GetBookIdByDisplaynameAndSupplierId(txtbBookName.Text, Convert.ToInt32(lkpSupplier.EditValue));
            int amount = Convert.ToInt32(nmAmount.Value);
            int currentAmount = BooksDAO.Instance.GetCurrentAmountOfBook(idBook);
            int inputPrice = Convert.ToInt32(txtbInputPrice.Text);
            int outputPrice = Convert.ToInt32(txtbOutputPrice.Text);

            bool isAddInputDetailSuccess = AddNewInputDetail(idBook, amount, idInput, inputPrice, outputPrice);
            bool isUpdateBookSuccess = UpdateBookWhenInsertInputDetail(idBook, idSupplier, amount + currentAmount, outputPrice);

            if (isAddInputDetailSuccess && isUpdateBookSuccess)
            {
                XtraMessageBox.Show("Thành công");
                LoadInputDetailList(idInput);
            }
            else
            {
                XtraMessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void gvInput_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = e.FocusedRowHandle;
            try
            {
                //Đầu chạy thì GetRowCellValue trả về null, xử lí lỗi throw null exception
                if (gvInput.GetRowCellValue(index, "Mã PN") == null)
                {
                    LoadInputDetailList(InputDAO.Instance.GetTop1InputId());
                    return;
                }
                if (index >= 0)
                {
                    string idInput = gvInput.GetRowCellValue(index, "Mã PN").ToString();
                    LoadInputDetailList(idInput);
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error " + ex.ToString());
            }
        }
        private void btnNewInput_Click(object sender, EventArgs e)
        {
            try
            {
                string inputId = txtbInputId.Text;
                DateTime dateInput = dtpkInputDate.Value;
                int idSupplier = Convert.ToInt32(lkpSupplier.EditValue);
                int idBook = BooksDAO.Instance.GetBookIdByDisplaynameAndSupplierId(txtbBookName.Text, Convert.ToInt32(lkpSupplier.EditValue));
                int amount = Convert.ToInt32(nmAmount.Value);
                decimal inputPrice = Convert.ToDecimal(txtbInputPrice.Text);
                decimal outputPrice = Convert.ToDecimal(txtbOutputPrice.Text);
                int currentAmount = BooksDAO.Instance.GetCurrentAmountOfBook(idBook);


                bool isInsertNewInputSuccess = AddNewInput(inputId, dateInput, idSupplier);
                bool isInsertInputDetailSuccess = AddNewInputDetail(idBook, amount, inputId, inputPrice, outputPrice);
                bool isUpdateBookInfoSuccess = UpdateBookWhenInsertInputDetail(idBook, idSupplier, currentAmount + amount, outputPrice);
                if (isInsertNewInputSuccess && isInsertInputDetailSuccess && isUpdateBookInfoSuccess)
                {
                    XtraMessageBox.Show("Thành công");
                    LoadInputList();
                }
                else
                {
                    XtraMessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error " + ex.ToString());
            }
        }
        #endregion

        private void txtbBookName_Properties_Leave(object sender, EventArgs e)
        {
            int idBook = BooksDAO.Instance.GetBookIdByDisplaynameAndSupplierId(txtbBookName.Text, Convert.ToInt32(lkpSupplier.EditValue));
            if (idBook == -1)
            {
                if (XtraMessageBox.Show("Sách chưa tồn tại, bạn có muốn thêm sách này không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    FormBook form = new FormBook();
                    form.ShowDialog();
                }
            }
        }
    }
}