using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DataAccessLayer
{
    public class BookMenu
    {
        private string _bookName;
        private int _amount;
        private decimal _price;
        private decimal _totalPPrice;

        public string BookName { get => _bookName; set => _bookName = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public decimal Price { get => _price; set => _price = value; }
        public decimal TotalPPrice { get => _totalPPrice; set => _totalPPrice = value; }

        public BookMenu(string bookName, int amount, decimal price, decimal totalPrice = 0)
        {
            this.BookName = bookName;
            this.Amount = amount;
            this.Price = price;
            this.TotalPPrice = totalPrice;

        }
        public BookMenu(DataRow dataRow)
        {
            this.BookName = dataRow["DisplayName"].ToString();
            this.Amount = (int)dataRow["Amount"];
            this.Price = (decimal)dataRow["Price"];
            this.TotalPPrice = (decimal)dataRow["TotalPrice"];
        }
    }
}
