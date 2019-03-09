using QLNS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BusinessAccessLayer
{
    public class InputDAO
    {
        private static InputDAO _instance;

        public static InputDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InputDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }

        private InputDAO() { }

        public DataTable LoadInputList()
        {
            //List<Inputs> list = new List<Inputs>();
            string query = "SELECT inputId AS [Mã PN], DateReceipt AS [Ngày nhập], idSupplier AS [Tên NCC] FROM dbo.Inputs";
            return DataProvider.Instance.ExcuteQuery(query);
            //foreach (DataRow item in data.Rows)
            //{
            //    Inputs input = new Inputs(item);
            //    list.Add(input);
            //}
            //return list;
        }

        public string GetTop1InputId()
        {
            string query = "SELECT TOP 1 inputId FROM dbo.Inputs";
            return DataProvider.Instance.ExcuteScalar(query).ToString();
        }

        public bool InsertInput(string inputId, DateTime dateInput, int idSupplier)
        {
            string query = string.Format("INSERT INTO dbo.Inputs ( inputId, DateReceipt, idSupplier ) VALUES  ( N'{0}', '{1}', {2} )", inputId, dateInput.ToString("MM-dd-yyyy"), idSupplier);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

    }
}
