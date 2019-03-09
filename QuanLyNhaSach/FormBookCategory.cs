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
    public partial class FormBookCategory : DevExpress.XtraEditors.XtraForm
    {
        BindingSource listCategory = new BindingSource();
        public FormBookCategory()
        {
            InitializeComponent();
            gvCategory.GridControl.DataSource = listCategory;
            LoadListCategory();
            CategoryBinding();
        }
        #region Methods
        void LoadListCategory()
        {
            listCategory.DataSource = BookCategoryDAO.Instance.GetListCategory();
        }
        void CategoryBinding()
        {
            txtbIdCategory.DataBindings.Add(new Binding("Text", gvCategory.GridControl.DataSource, "Mã danh mục", true, DataSourceUpdateMode.Never));
            txtbDisplayName.DataBindings.Add(new Binding("Text", gvCategory.GridControl.DataSource, "Tên danh mục", true, DataSourceUpdateMode.Never));
        }

        void AddBookCategory(string displayName)
        {
            if (BookCategoryDAO.Instance.InsertBookCategory(displayName))
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm dữ liệu");
            }
        }
        void UpdateBookCategory(int id, string displayName)
        {
            if (BookCategoryDAO.Instance.UpdateBookCategory(id, displayName))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật dữ liệu");
            }
        }
        void DeleteBookCategory(int id)
        {
            if (BookCategoryDAO.Instance.DeleteBookCategory(id))
            {
                MessageBox.Show("Xóa dữ liệu thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa dữ liệu");
            }
        }
        DataTable SearchCategoryByName(string keyword)
        {
            if (keyword != null)
            {
                return BookCategoryDAO.Instance.SearchCategoryByName(keyword);
            }
            else
            {
                return BookCategoryDAO.Instance.GetListCategory();
            }
        }
        #endregion


        #region Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBookCategory(txtbDisplayName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idCategory = Convert.ToInt32(txtbIdCategory.Text);
            if (MessageBox.Show("Bạn có chắc muốn xóa danh mục này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DeleteBookCategory(idCategory);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtbIdCategory.Text);
            string displayName = txtbDisplayName.Text;
            UpdateBookCategory(id, displayName);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtbKeyword.Text;
            listCategory.DataSource = SearchCategoryByName(keyword);
        }
        #endregion


    }
}