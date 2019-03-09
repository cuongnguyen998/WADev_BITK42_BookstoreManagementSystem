using QLNS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BusinessAccessLayer
{
    public class MenuDAO
    {
        private static MenuDAO _instance;

        public static MenuDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MenuDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }
        private MenuDAO() { }

        public List<Menus> GetListMenuByBillId(int id)
        {
            List<Menus> listMenus = new List<Menus>();
            string query = "SELECT bo.displayName,bi.amount, bo.unitPrice, bi.amount*bo.unitPrice AS totalPrice FROM dbo. Bill b, dbo.Books bo, dbo.BillDetail bi WHERE b.id = bi.idBill AND bo.id = bi.idBook AND b.id = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menus menus = new Menus(item);
                listMenus.Add(menus);
            }
            return listMenus;

        }

        public DataTable LoadHelpMenu()
        {
            string query = "SELECT [function] AS [Chức năng], shortcutKey AS [Phím tắt] FROM dbo.Help";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
    }
}
