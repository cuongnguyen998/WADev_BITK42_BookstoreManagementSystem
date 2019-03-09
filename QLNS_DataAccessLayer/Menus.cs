using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DataAccessLayer
{
    public class Menus
    {
        private string _bookName;
        private int _amount;
        private decimal _unitPrice;
        private decimal _totalPrice;

        public string BookName { get => _bookName; set => _bookName = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public decimal UnitPrice { get => _unitPrice; set => _unitPrice = value; }
        public decimal TotalPrice { get => _totalPrice; set => _totalPrice = value; }
        public Menus(string bookName, int amount, int unitPrice, decimal totalPrice)
        {
            this.BookName = bookName;
            this.Amount = amount;
            this.UnitPrice = unitPrice;
            this.TotalPrice = totalPrice;
        }
        public Menus(DataRow row)
        {
            this.BookName = row["displayName"].ToString();
            this.Amount = (int)row["amount"];
            this.UnitPrice = (decimal)row["unitPrice"];
            this.TotalPrice = (decimal)row["totalPrice"];
        }
    }
}
