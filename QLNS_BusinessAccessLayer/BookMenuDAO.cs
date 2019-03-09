using QLNS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BusinessAccessLayer
{
    public class BookMenuDAO
    {
        private static BookMenuDAO _instance;

        public static BookMenuDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BookMenuDAO();
                }
                return _instance;
            }
            private set => _instance = value;
        }
        private BookMenuDAO() { }

        
    }
}
