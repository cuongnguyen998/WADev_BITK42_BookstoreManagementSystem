using QLNS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BusinessAccessLayer
{
    public class BillDAO
    {
        private static BillDAO _instance;

        public static BillDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BillDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }
        private BillDAO() { }

        public void InsertBill(string idCustomer)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC dbo.USP_InsertBill @idCustomer ", new object[] { idCustomer });
        }
        public int GetMaxBillId()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(id) FROM	dbo.Bill");
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public bool IsExistBill(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Bill WHERE id = " + id);
            return data.Rows.Count > 0;
        }
        public void CheckOut(int idBill, decimal discount, decimal totalPrice)
        {
            string query = string.Format("UPDATE dbo.Bill SET status = 1, totalPrice = {0}, discount = {1} WHERE id = {2}", totalPrice, discount, idBill);
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        /// <summary>
        /// Tìm được: Trả về idCustomer
        /// Không tìm được: Trả về null
        /// </summary>
        /// <param name="idBill"></param>
        /// <returns></returns>
        public string GetCustomerIdByBillId(int idBill)
        {
            string query = String.Format("SELECT * FROM dbo.Customers WHERE customerId = (SELECT idCustomer FROM dbo.Bill WHERE id = {0})", idBill);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customers customer = new Customers(item);
                return customer.CustomerId;
            }
            return null;
        }


    }
}
