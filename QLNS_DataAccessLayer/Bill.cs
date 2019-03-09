using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DataAccessLayer
{
    public class Bill
    {
        private int _id;
        private DateTime? _buyDate;
        private decimal? _discount;
        private string idCustomer;
        private decimal? _totalPrice;
        private int _status;

        public int Id { get => _id; set => _id = value; }
        public DateTime? BuyDate { get => _buyDate; set => _buyDate = value; }
        public decimal? Discount { get => _discount; set => _discount = value; }
        public string IdCustomer { get => idCustomer; set => idCustomer = value; }
        public decimal? TotalPrice { get => _totalPrice; set => _totalPrice = value; }
        public int Status { get => _status; set => _status = value; }

        public Bill(int id, DateTime? buyDate, decimal discount, string idCustomer, decimal totalPrice, int status)
        {
            this.Id = id;
            this.BuyDate = buyDate;
            this.Discount = discount;
            this.IdCustomer = idCustomer;
            this.TotalPrice = totalPrice;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.BuyDate = (DateTime)row["BuyDate"];
            this.Discount = (decimal)row["discount"];
            this.IdCustomer = row["idCustomer"].ToString();
            this.TotalPrice = (decimal)row["totalPrice"];
            this.Status = (int)row["status"];
        }
    }
}
