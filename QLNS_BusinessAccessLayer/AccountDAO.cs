using QLNS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BusinessAccessLayer
{
    public class AccountDAO
    {
        private static AccountDAO _instance;

        public static AccountDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountDAO();
                }
                return AccountDAO._instance;
            }
            private set => AccountDAO._instance = value;
        }
        private AccountDAO() { }

        public DataTable GetAccountList()
        {
            string query = "SELECT userName AS [Tên đăng nhập], displayName AS [Tên hiển thị], role AS [Quyền] FROM dbo.Accounts";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public bool Login(string userName, string passWord)
        {
            passWord = MD5Hash(Base64Encode(passWord));
            DataTable result = DataProvider.Instance.ExcuteQuery("EXEC dbo.USP_Login @userName , @password ", new object[] { userName, passWord });
            return result.Rows.Count > 0;

        }
        public Accounts GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC dbo.USP_GetAccountByUsername @userName ", new object[] { userName });
            foreach (DataRow item in data.Rows)
            {
                return new Accounts(item);
            }
            return null;
        }
        public bool UpdateAccountInfo(string userName, string displayName, string passWord, string newPass)
        {
            passWord = MD5Hash(Base64Encode(passWord));
            if (newPass != "")
            {
                newPass = MD5Hash(Base64Encode(newPass));
            }

            int data = DataProvider.Instance.ExcuteNonQuery("EXEC dbo.USP_UpdateAccountInfo @userName , @displayName , @password , @newPass ", new object[] { userName, displayName, passWord, newPass });

            return data > 0;
        }
        public bool DeleteAccount(string userName)
        {
            string query = string.Format("DELETE dbo.Accounts WHERE userName = N'{0}'", userName);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateAccount(string userName, string displayName, int role)
        {
            string query = string.Format("UPDATE dbo.Accounts SET displayName = N'{0}', role = {1} WHERE userName = N'{2}'", displayName, role, userName);

            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool InsertAccount(string userName, string displayName, int role)
        {
            string password = MD5Hash(Base64Encode("1"));
            string query = string.Format("INSERT dbo.Accounts ( userName , displayName , passWord , role ) VALUES  ( N'{0}' , N'{1}' , N'{2}' , {3} )", userName, displayName, password, role);

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string userName)
        {
            string password = MD5Hash(Base64Encode("1"));
            string query = String.Format("UPDATE dbo.Accounts SET passWord = N'{0}' WHERE userName = N'{1}'", password, userName);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        //Mã hóa mật khẩu sang base64
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        //Mã hóa mật khẩu qua MD5 sau khi đã chuyển sang base 64
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
