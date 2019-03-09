using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DataAccessLayer
{
    public class Customers
    {
        private string _customerId;
        private string _displayName;
        private string _personalId;
        private DateTime? _birthDay;
        private string _address;
        private string _email;
        private string _moreInfo;

        public string CustomerId { get => _customerId; set => _customerId = value; }
        public string DisplayName { get => _displayName; set => _displayName = value; }
        public string PersonalId { get => _personalId; set => _personalId = value; }
        public DateTime? BirthDay { get => _birthDay; set => _birthDay = value; }
        public string Address { get => _address; set => _address = value; }
        public string Email { get => _email; set => _email = value; }
        public string MoreInfo { get => _moreInfo; set => _moreInfo = value; }
        public Customers(string id, string displayName, string personalId, DateTime? birthDay, string address, string email, string moreInfo)
        {
            this.CustomerId = id;
            this.DisplayName = displayName;
            this.BirthDay = birthDay;
            this.PersonalId = personalId;
            this.Address = address;
            this.Email = email;
            this.MoreInfo = moreInfo;
        }
        public Customers(DataRow row)
        {
            this.CustomerId = row["customerId"].ToString();
            if (row["displayName"].ToString() != "")
            {
                this.DisplayName = row["displayName"].ToString();
            }
            if (row["personalId"].ToString() != "")
            {
                this.PersonalId = row["personalId"].ToString();
            }
            if (row["birthDay"] != null)
            {
                this.BirthDay = (DateTime)row["birthDay"];
            }
            if (row["address"].ToString() != "")
            {
                this.Address = row["address"].ToString();
            }
            if (row["email"].ToString() != "")
            {
                this.Email = row["email"].ToString();
            }
            if (row["moreInfo"].ToString() != "")
            {
                this.MoreInfo = row["moreInfo"].ToString();
            }
            
        }
    }
}
