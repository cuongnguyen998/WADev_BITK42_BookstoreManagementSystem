using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS_DataAccessLayer;

namespace QLNS_BusinessAccessLayer
{
    public class BillDetailDAO
    {
        private static BillDetailDAO _instance;

        public static BillDetailDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BillDetailDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }
        private BillDetailDAO() { }
        public void InsertBillDetail(int idBill, int idBook, int amount)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC dbo.USP_InsertBillDetail @idBill , @idBook , @amount ", new object[] { idBill, idBook, amount });
        }

        public int GetMaxBillId()
        {
            return 1;
        }

        public void DeleteBillDetailByBookId(int id)
        {
            string query = String.Format("DELETE FROM dbo.BillDetail WHERE idBook = {0}", id);
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
