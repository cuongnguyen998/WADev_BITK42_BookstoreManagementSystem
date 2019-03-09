using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DataAccessLayer
{
    public class InputDetail
    {
        private int _id;
        private int _idBook;
        private int _amount;
        private string _idInput;
        private decimal _receiptPrice;
        private decimal _outputPrice;

        public int Id { get => _id; set => _id = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public string IdInput { get => _idInput; set => _idInput = value; }
        public decimal ReceiptPrice { get => _receiptPrice; set => _receiptPrice = value; }
        public decimal OutputPrice { get => _outputPrice; set => _outputPrice = value; }
        public int IdBook { get => _idBook; set => _idBook = value; }

        public InputDetail(int id, int idBook, int amount, string inputId, decimal receiptPrice, decimal outputPrice)
        {
            this.Id = id;
            this.IdBook = idBook;
            this.Amount = amount;
            this.IdInput = inputId;
            this.ReceiptPrice = receiptPrice;
            this.OutputPrice = outputPrice;
        }
        public InputDetail(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdBook = (int)row["idBook"];
            this.Amount = (int)row["amount"];
            this.IdInput = row["idStockReceipt"].ToString();
            this.ReceiptPrice = (decimal)row["receiptPrice"];
            this.OutputPrice = (decimal)row["outputPrice"];
        }
    }
}
