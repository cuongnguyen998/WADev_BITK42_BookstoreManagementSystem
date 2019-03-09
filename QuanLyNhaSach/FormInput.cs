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
            dtpkInputDate.DataBindings.Add(new Binding("EditValue", gctrlInput.DataSource, "Ngày nhập", true, DataSourceUpdateMode.Never));
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
            int inputId = Convert.ToInt32(txtbInputId.Text);
            DateTime dateInput = (DateTime)dtpkInputDate.EditValue;
            int idSupplier = Convert.ToInt32(lkpSupplier.EditValue);
            int idBook = BooksDAO.Instance.GetBookIdByBookCode(txtbBookName.Text);
            int amount = Convert.ToInt32(nmAmount.Value);
            decimal inputPrice = Convert.ToDecimal(txtbInputPrice.Text);
            decimal outputPrice = Convert.ToDecimal(txtbOutputPrice.Text);

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
        #endregion

    }
}