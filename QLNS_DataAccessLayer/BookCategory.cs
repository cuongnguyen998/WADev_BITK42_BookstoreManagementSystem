using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DataAccessLayer
{
    public class BookCategory
    {
        private int _id;
        private string _displayName;

        public int Id { get => _id; set => _id = value; }
        public string DisplayName { get => _displayName; set => _displayName = value; }
        public BookCategory(int id, string displayName)
        {
            this.Id = id;
            this.DisplayName = displayName;

        }
        public BookCategory(DataRow row)
        {
            this.Id = (int)row["id"];
            this.DisplayName = row["displayName"].ToString();
        }
    }
}
