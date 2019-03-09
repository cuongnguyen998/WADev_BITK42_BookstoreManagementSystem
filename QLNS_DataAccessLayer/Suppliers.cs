using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DataAccessLayer
{
    public class Suppliers
    {
        private int _id;
        private string _displayName;
        private string _address;
        private string _email;
        private string _phoneNumber;

        public int Id { get => _id; set => _id = value; }
        public string DisplayName { get => _displayName; set => _displayName = value; }
        public string Address { get => _address; set => _address = value; }
        public string Email { get => _email; set => _email = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public Suppliers(int id, string displayName, string address, string email, string phoneNumber)
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Address = address;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }
        public Suppliers(DataRow row)
        {
            this.Id = (int)row["id"];
            this.DisplayName = row["displayName"].ToString();
            this.Address = row["address"].ToString();
            this.Email = row["email"].ToString();
            this.PhoneNumber = row["phoneNumber"].ToString();
        }
    }
}
