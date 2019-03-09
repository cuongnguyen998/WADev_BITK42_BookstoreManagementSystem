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
using static System.Windows.Forms.ComboBox;

namespace QuanLyNhaSach
{
    public partial class FormAccountSetting : DevExpress.XtraEditors.XtraForm
    {
        BindingSource accountList = new BindingSource();
        public FormAccountSetting()
        {
            InitializeComponent();
            LoadAll();
        }
        #region Methods
        void ResetPassword(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công","Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi khi đặt lại mật khẩu", "Lỗi");
            }
        }
        void DeleteAccount(string userName)
        {
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                LoadAccountList();
                MessageBox.Show("Xóa dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa dữ liệu");
            }
        }
        void UpdateAccount(string displayName, int role, string userName)
        {
            if (AccountDAO.Instance.UpdateAccount(userName,displayName,role))
            {
                LoadAccountList();
                MessageBox.Show("Cập nhật dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật dữ liệu");
            }
        }
        void InsertAccount(string userName, string displayName, int role)
        {
            if (AccountDAO.Instance.InsertAccount(userName,displayName,role))
            {
                LoadAccountList();
                MessageBox.Show("Thêm dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm dữ liệu");
            }
        }
        void LoadCombobox(System.Windows.Forms.ComboBox cb)
        {
            cb.DataSource = AccountRoleDAO.Instance.GetAccountRoleList();
            cb.DisplayMember = "displayName";
            cb.ValueMember = "id";
        }
        void AccountBinding()
        {
            txtbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Tên đăng nhập", true, DataSourceUpdateMode.Never));
            txtbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
        }
        void LoadAccountList()
        {
            accountList.DataSource = AccountDAO.Instance.GetAccountList();
        }
        void LoadAll()
        {
            dtgvAccount.DataSource = accountList;
            LoadAccountList();

            AccountBinding();
            LoadCombobox(cbRole);
        }

        #endregion

        #region Events
        private void txtbUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rowCount = dtgvAccount.SelectedCells.Count;
                if (rowCount > 0)
                {
                    int id = (int)dtgvAccount.SelectedCells[0].OwningRow.Cells["Quyền"].Value;
                    AccountRole accountRole = AccountRoleDAO.Instance.GetAccountRoleById(id);
                    cbRole.SelectedItem = accountRole;
                    int index = -1;
                    int i = 1;
                    foreach (AccountRole item in cbRole.Items)
                    {
                        if (item.Id == accountRole.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbRole.SelectedValue = index;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Warning");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string userName = txtbUserName.Text;
            string displayName = txtbDisplayName.Text;
            int role = (int)cbRole.SelectedValue;
            UpdateAccount(displayName, role, userName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userName = txtbUserName.Text;
            if (MessageBox.Show("Bạn có thực sự muốn xóa tài khoản này","Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DeleteAccount(userName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName = txtbUserName.Text;
            string displayName = txtbDisplayName.Text;
            int role = (int)cbRole.SelectedValue;
            InsertAccount(userName, displayName, role);
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đặt lại mật khẩu cho tài khoản này?","Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ResetPassword(txtbUserName.Text);
            }
        }
        #endregion


    }
}