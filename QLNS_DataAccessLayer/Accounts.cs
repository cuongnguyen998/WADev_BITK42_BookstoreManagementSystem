using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DataAccessLayer
{
    public class Accounts
    {
        private string _userName;
        private string _displayName;
        private string _passWord;
        private int _role;

        public string UserName { get => _userName; set => _userName = value; }
        public string DisplayName { get => _displayName; set => _displayName = value; }
        public string PassWord { get => _passWord; set => _passWord = value; }
        public int Role { get => _role; set => _role = value; }
        public Accounts(string userName, string displayName, int role, string password = null)
        {
            this.UserName = userName;
            this.PassWord = password;
            this.DisplayName = displayName;
            this.Role = role;
        }
        public Accounts(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.PassWord = row["passWord"].ToString();
            this.Role = (int)row["role"];
        }
    }
}
