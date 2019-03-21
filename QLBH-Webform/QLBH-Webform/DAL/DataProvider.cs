using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DataProvider
    {
        //đang nghi vấn ở câu connection string này, sợ đem qua máy khác chạy không được
    /*    string connectionSTR = "Data Source=DESKTOP-A7LP6VN;Initial Catalog=quanlybanhang;Integrated Security=True"; 
        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection); //cau truy van de thuc thi
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); //trung gian de lay du lieu
                adapter.Fill(data); //do du lieu vao
                connection.Close();
                return data;
            }
        }*/

        protected MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=quanlybanhang");
    }
}
