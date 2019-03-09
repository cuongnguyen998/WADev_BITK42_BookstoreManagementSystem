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
    public partial class FormSupplier : DevExpress.XtraEditors.XtraForm
    {
        BindingSource supplierList = new BindingSource();
        public FormSupplier()
        {
            InitializeComponent();
            LoadAll();
        }
        #region Methods

        DataTable SearchSupplier(string keyword)
        {
            if (keyword != "")
            {
                return SuppliersDAO.Instance.SearchSupplierByName(keyword);
            }
            else
            {
                return SuppliersDAO.Instance.LoadListSupplier();
            }
        }
        void UpdateSupplier(int idSupplier, string displayName, string address, string email, string phoneNumber)
        {
            if (SuppliersDAO.Instance.UpdateSupplier(idSupplier, displayName, address, email, phoneNumber))
            {
                XtraMessageBox.Show("Cập nhật dữ liệu thành công");
                LoadListSupplier();
            }
            else
            {
                XtraMessageBox.Show("Có lỗi khi cập nhật dữ liệu");
            }
        }
        //Chức năng này chưa hoàn thiện
        void DeleteSupplier(int idSupplier)
        {

        }
        void AddSupplier(string displayName, string address, string email, string phoneNumber)
        {
            if (SuppliersDAO.Instance.InsertSupplier(displayName, address, email, phoneNumber))
            {
                XtraMessageBox.Show("Thêm dữ liệu thành công");
                LoadListSupplier();
            }
            else
            {
                XtraMessageBox.Show("Có lỗi khi thêm dữ liệu");
            }
        }
        void SupplierBinding()
        {
            txtbSupplierId.DataBindings.Add(new Binding("Text", gvSupplier.GridControl.DataSource, "Mã NCC", true, DataSourceUpdateMode.Never));
            txtbDisplayName.DataBindings.Add(new Binding("Text", gvSupplier.GridControl.DataSource, "Tên NCC", true, DataSourceUpdateMode.Never));
            txtbAddress.DataBindings.Add(new Binding("Text", gvSupplier.GridControl.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            txtbEmail.DataBindings.Add(new Binding("Text", gvSupplier.GridControl.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtbPhoneNumber.DataBindings.Add(new Binding("Text", gvSupplier.GridControl.DataSource, "Điện thoại", true, DataSourceUpdateMode.Never));
        }
        void LoadListSupplier()
        {
            supplierList.DataSource = SuppliersDAO.Instance.LoadListSupplier();
        }

        void LoadAll()
        {
            gvSupplier.GridControl.DataSource = supplierList;
            LoadListSupplier();
            SupplierBinding();
        }

        #endregion

        #region Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            supplierList.DataSource = SearchSupplier(txtbKeyword.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string displayName = txtbDisplayName.Text;
            string address = txtbAddress.Text;
            string email = txtbEmail.Text;
            string phoneNumber = txtbPhoneNumber.Text;
            AddSupplier(displayName, address, email, phoneNumber);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idSupplier = Convert.ToInt32(txtbSupplierId.Text);
            string displayName = txtbDisplayName.Text;
            string email = txtbEmail.Text;
            string address = txtbAddress.Text;
            string phoneNumber = txtbPhoneNumber.Text;
            if (XtraMessageBox.Show("Bạn có muốn lưu những thay đổi?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                UpdateSupplier(idSupplier, displayName, address, email, phoneNumber);
            }
        }
        #endregion


    }
}