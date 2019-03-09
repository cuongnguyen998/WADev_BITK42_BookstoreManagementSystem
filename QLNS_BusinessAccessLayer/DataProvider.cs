using QLNS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BusinessAccessLayer
{
    public class DataProvider
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=BMS;User ID=sa;Password=123456789";
        //Sử dụng cấu trúc Singleton
        private static DataProvider _instance;

        public static DataProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataProvider();
                }
                return _instance;
            }
            private set => _instance = value;
        }

        #region sử dụng Ado.net thì dùng cái đoạn này
        //Tạo các hàm xử lý cần thiết

        /// <summary>
        /// Hàm thực hiện những câu truy vấn đến database, truyền vào câu truy vấn và danh sách các tham số(nếu có), mặc định tham số là null
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Mở kết nối đến database
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        /// <summary>
        /// Sử dụng cho trường hợp kiểm tra update
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// Sử dụng cho trường hợp select Max, count,...
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listParam = query.Split(' ');
                    foreach (string item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        #endregion

    }
}
