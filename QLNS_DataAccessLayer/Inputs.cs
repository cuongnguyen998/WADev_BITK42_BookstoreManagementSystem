using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNS_DataAccessLayer
{
    public class Inputs
    {

        private string _inputId;
        private DateTime _dateReceipt;
        private int _idSupplier;

        public string InputId { get => _inputId; set => _inputId = value; }
        public DateTime DateReceipt { get => _dateReceipt; set => _dateReceipt = value; }
        public int IdSupplier { get => _idSupplier; set => _idSupplier = value; }

        public Inputs(string inputId, DateTime date, int idSupplier)
        {
            this.InputId = inputId;
            this.DateReceipt = date;
            this.IdSupplier = idSupplier;
        }
        public Inputs(DataRow row)
        {
            this.InputId = row["inputId"].ToString();
            this.DateReceipt = (DateTime)row["DateReceipt"];
            this.IdSupplier = (int)row["idSupplier"];

        }
    }
}
