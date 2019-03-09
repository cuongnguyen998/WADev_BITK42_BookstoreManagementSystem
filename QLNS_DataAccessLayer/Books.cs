using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DataAccessLayer
{
    public class Books
    {
        private int _id;
        private string _bookCode;
        private string _displayName;
        private int _idCategory;
        private int _idSupplier;
        private int _status;
        private decimal _unitPrice;
        private int _amount;

        public int Id { get => _id; set => _id = value; }
        public string BookCode { get => _bookCode; set => _bookCode = value; }
        public string DisplayName { get => _displayName; set => _displayName = value; }
        public int IdCategory { get => _idCategory; set => _idCategory = value; }
        public int IdSupplier { get => _idSupplier; set => _idSupplier = value; }
        public int Status { get => _status; set => _status = value; }
        public decimal UnitPrice { get => _unitPrice; set => _unitPrice = value; }
        public int Amount { get => _amount; set => _amount = value; }

        public Books(int id, string bookCode, string displayName, int idCategory, int idSupplier, int status, decimal unitPrice, int amount)
        {
            this.Id = id;
            this.BookCode = bookCode;
            this.DisplayName = displayName;
            this.IdCategory = idCategory;
            this.IdSupplier = idSupplier;
            this.Status = status;
            this.UnitPrice = unitPrice;
            this.Amount = amount;
        }
        public Books(DataRow row)
        {
            this.Id = (int)row["id"];
            this.BookCode = row["bookCode"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.IdCategory = (int)row["idCategory"];
            this.IdSupplier = (int)row["idSupplier"];
            this.Status = (int)row["status"];
            this.UnitPrice = (decimal)row["unitPrice"];
            this.Amount = (int)row["amount"];
        }
    }
}
