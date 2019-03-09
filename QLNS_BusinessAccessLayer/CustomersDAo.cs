using QLNS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BusinessAccessLayer
{
    public class CustomersDAO
    {
        private static CustomersDAO _instance;

        public static CustomersDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CustomersDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }
        private CustomersDAO() { }

        public DataTable GetListCustomer()
        {
            return DataProvider.Instance.ExcuteQuery("SELECT customerId AS [Mã khách hàng], displayName AS [Họ và tên], birthDay AS [Ngày sinh], personalId AS [CMND], address AS [Địa chỉ], email AS [Email],moreInfo AS [Ghi chú] FROM dbo.Customers");
        }
        public bool InsertCustomer(string customerId, string displayName, DateTime birthday, string personalId, string address, string email, string moreInfo)
        {
            string query = string.Format("INSERT INTO dbo.Customers ( customerId , displayName , birthDay , personalId , address , email , moreInfo ) VALUES(N'{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', N'{6}')", customerId, displayName, birthday.ToString("MM-dd-yyyy"), personalId, address, email, moreInfo);

            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCustomer(string customerId, string displayName, DateTime birthday, string personalId, string address, string email, string moreInfo)
        {
            string query = string.Format("UPDATE dbo.Customers SET displayName = N'{0}', birthDay = '{1}', personalId = N'{2}',address = N'{3}', email = N'{4}', moreInfo = N'{5}' WHERE customerId = N'{6}'", displayName, birthday.ToString("MM-dd-yyyy"), personalId, address, email, moreInfo,customerId);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public DataTable SearchCustomerByName(string displayName)
        {
            string query = String.Format("SELECT customerId AS [Mã khách hàng], displayName AS [Họ và tên], birthDay AS [Ngày sinh], personalId AS [CMND], address AS [Địa chỉ], email AS [Email], moreInfo AS [Ghi chú] FROM dbo.Customers WHERE displayName LIKE N'%{0}%'", displayName);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
    }
}
