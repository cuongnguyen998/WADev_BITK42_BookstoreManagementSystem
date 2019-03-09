using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS_DataAccessLayer;

namespace QLNS_BusinessAccessLayer
{
    public class SuppliersDAO
    {
        private static SuppliersDAO _instance;

        public static SuppliersDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SuppliersDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }
        private SuppliersDAO() { }

        public DataTable LoadListSupplier()
        {
            //List<Suppliers> list = new List<Suppliers>();
            //string query = "SELECT id, displayName, address, email, phoneNumber FROM dbo.Suppliers";

            //DataTable data = DataProvider.Instance.ExcuteQuery(query);

            //foreach (DataRow item in data.Rows)
            //{
            //    Suppliers supplier = new Suppliers(item);
            //    list.Add(supplier);
            //}
            //return list;

            string query = "SELECT id AS [Mã NCC], displayName AS [Tên NCC], address AS [Địa chỉ], email AS [Email], phoneNumber AS [Điện thoại] FROM dbo.Suppliers";
            return DataProvider.Instance.ExcuteQuery(query);

        }

        public bool InsertSupplier(string displayName, string address, string email, string phoneNumber)
        {
            string query = String.Format("INSERT dbo.Suppliers (displayName , address , email , phoneNumber) VALUES  ( N'{0}', N'{1}', N'{2}' , N'{3}')", displayName, address, email, phoneNumber);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateSupplier(int idSupplier,string displayName, string address, string email, string phoneNumber)
        {
            string query = String.Format("UPDATE dbo.Suppliers SET displayName = N'{0}', address = N'{1}', email = N'{2}', phoneNumber = N'{3}' WHERE id = {4}", displayName, address, email, phoneNumber, idSupplier);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteSupplier(int id)
        {
            return true;
        }

        public DataTable SearchSupplierByName(string displayName)
        {
            //List<Suppliers> list = new List<Suppliers>();

            string query = String.Format("SELECT * FROM dbo.Suppliers WHERE displayName LIKE N'%{0}%'", displayName);

            return DataProvider.Instance.ExcuteQuery(query);
            //foreach (DataRow item in data.Rows)
            //{
            //    Suppliers supplier = new Suppliers(item);
            //    list.Add(supplier);
            //}
            //return list;


        }

        public Suppliers GetSupplierById(int id)
        {
            Suppliers supplier = null;
            string query = "SELECT * FROM dbo.Suppliers WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                supplier = new Suppliers(item);
                return supplier;
            }

            return supplier;
        }
    }
}
