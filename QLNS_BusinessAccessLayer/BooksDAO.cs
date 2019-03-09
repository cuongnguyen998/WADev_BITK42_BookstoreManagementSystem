using QLNS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BusinessAccessLayer
{
    public class BooksDAO
    {
        private static BooksDAO _instance;

        public static BooksDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BooksDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }
        private BooksDAO() { }
        public int GetBookIdByBookCode(string bookCode)
        {
            string query = string.Format("SELECT * FROM dbo.Books WHERE bookCode = N'{0}'", bookCode);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Books book = new Books(item);
                return book.Id;
            }
            return -1;
        }
        
        public int GetBookIdByDisplaynameAndSupplierId(string displayName, int idSupplier)
        {
            string query = string.Format("SELECT * FROM dbo.Books WHERE displayName = N'{0}' AND idSupplier = {1}", displayName, idSupplier);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Books book = new Books(item);
                return book.Id;
            }
            return -1;
        }
        public string GetBookCodeById(int id)
        {
            string query = string.Format("SELECT * FROM dbo.Books WHERE id = {0}", id);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Books book = new Books(item);
                return book.BookCode;
            }
            return null;
        }

        public DataTable LoadListBook()
        {
            string query = "SELECT bookCode AS [Mã sách],displayName AS [Tên sách],idCategory AS [Mã danh mục],idSupplier AS [Mã NCC],unitPrice AS [Đơn giá],amount AS [Số lượng],status AS [Trạng thái] FROM dbo.Books";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public bool UpdateBook(string bookCode, string displayName, int idCategory, int idSupplier, decimal unitPrice, int amount, int status)
        {
            string query = string.Format("UPDATE dbo.Books SET displayName = N'{0}', idCategory = {1},idSupplier = {2},unitPrice = {3}, amount = {4}, status = {5} WHERE bookCode = N'{6}'", displayName, idCategory, idSupplier, unitPrice, amount, status, bookCode);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteBook(string bookCode)
        {

            string query = string.Format("DELETE FROM dbo.Books WHERE bookCode = N'{0}'", bookCode);

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public DataTable SearchBookByName(string keyword)
        {
            string query = string.Format("SELECT bookCode AS [Mã sách],displayName AS [Tên sách],idCategory AS [Mã danh mục],idSupplier AS [Mã NCC],unitPrice AS [Đơn giá],amount AS [Số lượng],status AS [Trạng thái] FROM dbo.Books WHERE displayName LIKE N'%{0}%'", keyword);
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public bool InsertNewBook(string bookCode, string dislayName, int idCategory, int idSupplier, decimal unitPrice, int amount)
        {
            string query = string.Format("INSERT dbo.Books( bookCode , displayName , idCategory , idSupplier , status , unitPrice , amount) VALUES  ( N'{0}' , N'{1}' , {2} , {3} , 1 , {4} , {5})", bookCode, dislayName, idCategory, idSupplier, unitPrice, amount);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public int GetCurrentAmountOfBook(int idBook)
        {
            Books book = null;
            string query = "SELECT * FROM dbo.Books WHERE id = " + idBook;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                book = new Books(item);
                return book.Amount;
            }
            return 0;
        }
        public bool UpdateBookWhenInsertInputDetail(int idBook,int idSupplier, int amount, decimal unitPrice)
        {
            string query = string.Format("UPDATE dbo.Books SET amount = {0}, unitPrice = {1}, status = 1 WHERE id = {2} AND idSupplier = {3}", amount, unitPrice, idBook, idSupplier);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
