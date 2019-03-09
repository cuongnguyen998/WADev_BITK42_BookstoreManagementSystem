using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
#pragma warning disable CS0246 // The type or namespace name 'QLNS_BusinessAccessLayer' could not be found (are you missing a using directive or an assembly reference?)
using QLNS_BusinessAccessLayer;
#pragma warning restore CS0246 // The type or namespace name 'QLNS_BusinessAccessLayer' could not be found (are you missing a using directive or an assembly reference?)
using QLNS_DataAccessLayer;

namespace QuanLyNhaSach
{
    public partial class FormBook : DevExpress.XtraEditors.XtraForm
    {
        BindingSource listSupplier = new BindingSource();
        BindingSource listCategory = new BindingSource();
        BindingSource listBook = new BindingSource();
        public FormBook()
        {
            InitializeComponent();
            LoadAll();
        }
        #region Methods

        void InsertBook(string bookCode, string displayName, int idCategory, int idSupplier, decimal unitPrice, int amount)
        {
            if (BooksDAO.Instance.InsertNewBook(bookCode, displayName, idCategory, idSupplier, unitPrice, amount))
            {
                XtraMessageBox.Show("Thành công");
                LoadListBook();
            }
            else
            {
                XtraMessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
            }
        }

        void SearchBookByName(string keyword)
        {
            listBook.DataSource = BooksDAO.Instance.SearchBookByName(keyword);
        }
        void DeleteBook(string bookCode)
        {
            if (BooksDAO.Instance.DeleteBook(bookCode))
            {
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                LoadListBook();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa dữ liệu", "Lỗi");
            }
        }
        void UpdateBook(string bookCode, string displayName, int idCategory, int idSupplier, decimal unitPrice, int amount, int status)
        {
            if (BooksDAO.Instance.UpdateBook(bookCode,displayName,idCategory,idSupplier,unitPrice,amount,status))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                LoadListBook();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật dữ liệu", "Lỗi");
            }
        }
        void BindingBooks()
        {
            txtBookCode.DataBindings.Add(new Binding("Text", gvBook.GridControl.DataSource, "Mã sách", true, DataSourceUpdateMode.Never));
            txtbDisplayName.DataBindings.Add(new Binding("Text", gvBook.GridControl.DataSource, "Tên sách", true, DataSourceUpdateMode.Never));
            txtbUnitPrice.DataBindings.Add(new Binding("Text", gvBook.GridControl.DataSource, "Đơn giá", true, DataSourceUpdateMode.Never));
            txtbAmount.DataBindings.Add(new Binding("Text", gvBook.GridControl.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
            txtbStatus.DataBindings.Add(new Binding("Text", gvBook.GridControl.DataSource, "Trạng thái", true, DataSourceUpdateMode.Never));
            lkpCategory.DataBindings.Add(new Binding("EditValue", gvBook.GridControl.DataSource, "Mã danh mục", true, DataSourceUpdateMode.Never));
            lkpSupplier.DataBindings.Add(new Binding("EditValue", gvBook.GridControl.DataSource, "Mã NCC", true, DataSourceUpdateMode.Never));
        }
        void LoadSupplierIntoLookupBox(LookUpEdit lookUp)
        {
            listSupplier.DataSource = SuppliersDAO.Instance.LoadListSupplier();
            lookUp.Properties.DataSource = listSupplier;
            lookUp.Properties.DisplayMember = "Tên NCC";
            lookUp.Properties.ValueMember = "Mã NCC";
        }
        void LoadCategoryIntoLookupBox(LookUpEdit lookUp)
        {
            listCategory.DataSource = BookCategoryDAO.Instance.GetListCategory();
            lookUp.Properties.DataSource = listCategory;
            lookUp.Properties.DisplayMember = "Tên danh mục";
            lookUp.Properties.ValueMember = "Mã danh mục";

        }
        void LoadListBook()
        {
            listBook.DataSource = BooksDAO.Instance.LoadListBook();
        }
        void LoadAll()
        {
            gvBook.GridControl.DataSource = listBook;
            LoadListBook();
            LoadSupplierIntoLookupBox(lkpSupplier);
            LoadCategoryIntoLookupBox(lkpCategory);
            BindingBooks();
        }
        #endregion


        #region Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBookByName(txtbKeyword.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bookCode = txtBookCode.Text;
            string displayName = txtbDisplayName.Text;
            int idCategory = Convert.ToInt32(lkpCategory.EditValue);
            int idSupplier = Convert.ToInt32(lkpSupplier.EditValue);
            int amount = Convert.ToInt32(txtbAmount.Text);
            decimal unitPrice = Convert.ToDecimal(txtbUnitPrice.Text);
            InsertBook(bookCode, displayName, idCategory, idSupplier, unitPrice, amount);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắc muốn xóa quyển sách này?","Cảnh báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int idBook = BooksDAO.Instance.GetBookIdByBookCode(txtBookCode.Text);
                BillDetailDAO.Instance.DeleteBillDetailByBookId(idBook);
                DeleteBook(txtBookCode.Text);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string bookCode = txtBookCode.Text;
            string displayName = txtbDisplayName.Text;
            decimal unitPrice = Convert.ToDecimal(txtbUnitPrice.Text);
            int amount = Convert.ToInt32(txtbAmount.Text);
            int idCategory = Convert.ToInt32(lkpCategory.EditValue);
            int idSupplier = Convert.ToInt32(lkpSupplier.EditValue);
            int status = Convert.ToInt32(txtbStatus.Text);
            if (MessageBox.Show("Bạn có muốn cập nhật lại thông tin của quyển sách này?","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                UpdateBook(bookCode,displayName,idCategory,idSupplier,unitPrice,amount,status);
            }
        }
        #endregion

    }
}