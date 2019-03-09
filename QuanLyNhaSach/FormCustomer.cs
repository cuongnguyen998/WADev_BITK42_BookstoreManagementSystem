using DevExpress.XtraEditors;
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
namespace QuanLyNhaSach
{
    public partial class FormCustomer : DevExpress.XtraEditors.XtraForm
    {
        BindingSource customerList = new BindingSource();
        public FormCustomer()
        {
            InitializeComponent();
            LoadAll();
        }
        #region Methods
        DataTable SearchCustomer(string keyword)
        {
            
            if (keyword != null)
            {
                return CustomersDAO.Instance.SearchCustomerByName(keyword);
            }
            else
            {
                return CustomersDAO.Instance.GetListCustomer();
            }
            
        }
        void AddCustomer(string customerId, string displayName, DateTime birthDay, string personalId, string address, string email, string moreInfo)
        {
            if (CustomersDAO.Instance.InsertCustomer(customerId, displayName, birthDay, personalId, address, email, moreInfo))
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                LoadListCustomer();
            }
            else
            {
                MessageBox.Show("Có lỗi khi nhập dữ liệu");
            }
        }
        void DeleteCustomer()
        {

        }
        void UpdateCustomer(string idCustomer, string displayName, DateTime birthday, string personalId, string address, string email, string moreInfo)
        {
            if (CustomersDAO.Instance.UpdateCustomer(idCustomer,displayName,birthday,personalId,address,email,moreInfo))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadListCustomer();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật dữ liệu");
            }
        }
        void LoadAll()
        {
            gvCustomer.GridControl.DataSource = customerList;
            LoadListCustomer();
            CustomerBinding();
        }
        void LoadListCustomer()
        {
            customerList.DataSource = CustomersDAO.Instance.GetListCustomer();
        }
        void CustomerBinding()
        {
            txtbCustomerId.DataBindings.Add(new Binding("Text", gvCustomer.GridControl.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never));
            txtbDisplayName.DataBindings.Add(new Binding("Text", gvCustomer.GridControl.DataSource, "Họ và tên", true, DataSourceUpdateMode.Never));
            dtpkBirthday.DataBindings.Add(new Binding("Value", gvCustomer.GridControl.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never));
            txtbPersonalId.DataBindings.Add(new Binding("Text", gvCustomer.GridControl.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txtbAddress.DataBindings.Add(new Binding("Text", gvCustomer.GridControl.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            txtbEmail.DataBindings.Add(new Binding("Text", gvCustomer.GridControl.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtbMoreInfo.DataBindings.Add(new Binding("Text", gvCustomer.GridControl.DataSource, "Ghi chú", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerId = txtbCustomerId.Text;
            string displayName = txtbDisplayName.Text;
            DateTime birthday = dtpkBirthday.Value;
            string personalId = txtbPersonalId.Text;
            string address = txtbAddress.Text;
            string email = txtbEmail.Text;
            string moreInfo = txtbMoreInfo.Text;
            AddCustomer(customerId, displayName, birthday, personalId, address, email, moreInfo);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string customerId = txtbCustomerId.Text;
            string displayName = txtbDisplayName.Text;
            DateTime birthday = dtpkBirthday.Value;
            string personalId = txtbPersonalId.Text;
            string address = txtbAddress.Text;
            string email = txtbEmail.Text;
            string moreInfo = txtbMoreInfo.Text;
            UpdateCustomer(customerId,displayName,birthday,personalId,address,email,moreInfo);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            customerList.DataSource = SearchCustomer(txtbKeyword.Text);
        }
        #endregion


    }
}