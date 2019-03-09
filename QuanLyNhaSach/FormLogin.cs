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
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        #region Methods
        bool isLogin(string userName, string Password)
        {
            return AccountDAO.Instance.Login(userName, Password);
        }
        void Login()
        {
            string userName = txtbUserName.Text;
            string passWord = txtbPassword.Text;
            if (isLogin(userName, passWord))
            {
                Accounts loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                FormMain main = new FormMain(loginAccount);
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}