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
    public partial class AccountInfoForm : DevExpress.XtraEditors.XtraForm
    {
        public AccountInfoForm()
        {
            InitializeComponent();
        }
        private Accounts _loginAccount;
        public Accounts LoginAccount { get => _loginAccount; set { _loginAccount = value; GetAccountInfo(_loginAccount); } }
        public AccountInfoForm(Accounts account)
        {
            InitializeComponent();
            this.LoginAccount = account;
        }
        #region Methods
        void GetAccountInfo(Accounts account)
        {
            txtDisplayName.Text = LoginAccount.DisplayName;
            txtUserName.Text = LoginAccount.UserName;

        }
        void UpdateAccountInfo()
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            string passWord = txtPassword.Text;
            string newPass = txtNewPassword.Text;
            string reenterPass = txtReenterPass.Text;

            if (!newPass.Equals(reenterPass))
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng!!!", "Thông báo");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccountInfo(userName, displayName, passWord, newPass))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    _updateAccount?.Invoke(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu!", "Thông báo");
                }
            }
        }
        #endregion
        private event EventHandler<AccountEvent> _updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { _updateAccount += value; }
            remove { _updateAccount -= value; }
        }

        #region Events
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
    public class AccountEvent : EventArgs
    {
        private Accounts _account;

        public Accounts Account { get => _account; set => _account = value; }
        public AccountEvent(Accounts acc)
        {
            this.Account = acc;
        }
    }
}