using QLNS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BusinessAccessLayer
{
    public class AccountRoleDAO
    {
        private static AccountRoleDAO _instance;

        public static AccountRoleDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountRoleDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }
        private AccountRoleDAO() { }

        public List<AccountRole> GetAccountRoleList()
        {
            List<AccountRole> listAccRole = new List<AccountRole>();
            string query = "SELECT * FROM dbo.AccountRole";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                AccountRole acc = new AccountRole(item);
                listAccRole.Add(acc);
            }
            return listAccRole;
        }
        public AccountRole GetAccountRoleById(int id)
        {
            AccountRole accountRole = null;
            string query = String.Format("SELECT * FROM dbo.AccountRole WHERE id = {0}", id);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                accountRole = new AccountRole(item);
                return accountRole;

            }
            return accountRole;
        }
        

    }
}
