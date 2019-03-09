using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS_DataAccessLayer;

namespace QLNS_BusinessAccessLayer
{
    public class InputDetailDAO
    {
        private static InputDetailDAO _instance;

        public static InputDetailDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InputDetailDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }

        private InputDetailDAO() { }
        public DataTable LoadInputDetailByInputId(string id)
        {
            string query = string.Format("SELECT b.displayName AS [Tên sách], bc.id AS [Danh mục],id.amount AS [Số lượng], id.receiptPrice AS [Giá nhập], id.outputPrice AS [Giá bìa] FROM dbo.InputDetail id, dbo.Inputs i, dbo.Books b, dbo.BookCategory bc WHERE id.idBook = b.id AND id.idStockReceipt = i.inputId AND b.idCategory = bc.id AND i.inputId = N'{0}'", id);
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public bool InsertInputDetail(int idBook, int amount, string idInput, decimal outputPrice, decimal inputPrice)
        {
            string query = string.Format("INSERT dbo.InputDetail ( idBook , amount , idStockReceipt , receiptPrice , outputPrice ) VALUES  ( {0} , {1} , N'{2}' , {3} , {4} )", idBook, amount, idInput, inputPrice, outputPrice);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
