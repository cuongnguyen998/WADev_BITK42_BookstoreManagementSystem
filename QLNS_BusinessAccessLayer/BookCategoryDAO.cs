using QLNS_BusinessAccessLayer;
using QLNS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLNS_BusinessAccessLayer
{
    public class BookCategoryDAO
    {
        private static BookCategoryDAO _instance;

        public static BookCategoryDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BookCategoryDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }
        private BookCategoryDAO() { }

        public DataTable GetListCategory()
        {
            string query = "SELECT id AS [Mã danh mục], displayName AS [Tên danh mục] FROM dbo.BookCategory";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public bool InsertBookCategory(string displayName)
        {
            string query = string.Format("INSERT INTO dbo.BookCategory ( displayName ) VALUES  ( N'{0}')", displayName);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateBookCategory(int id, string displayName)
        {
            string query = String.Format("UPDATE dbo.BookCategory SET	displayName = N'{0}' WHERE id = {1}", displayName, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteBookCategory(int id)
        {
            string query = "DELETE FROM	dbo.BookCategory WHERE id = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public DataTable SearchCategoryByName(string displayName)
        {
            string query = String.Format("SELECT id AS [Mã danh mục], displayName AS [Tên danh mục] FROM dbo.BookCategory WHERE displayName LIKE N'%{0}%'", displayName);
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public BookCategory GetBookCategoryById(int id)
        {
            BookCategory category = null;
            string query = "SELECT * FROM dbo.BookCategory WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new BookCategory(item);
                return category;

            }
            return category;
        }
    }
}
