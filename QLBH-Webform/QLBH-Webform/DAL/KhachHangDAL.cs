using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class KhachHangDAL : DataProvider
    {
        public DataTable LoadDSKhachHang()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from khachhang", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            return result;
        }
        public int themKHVangLai(string tenKH, string diachi, string sdt)
        {
            try
            {
                connection.Open();
                string SQL = string.Format("INSERT INTO khachhang(tenkh,diachi,sdt) VALUES ('{0}', '{1}', '{2}')", tenKH, diachi, sdt);
                MySqlCommand cmd = new MySqlCommand(SQL, connection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MySqlDataAdapter sql = new MySqlDataAdapter("select makh from khachhang order by makh desc limit 1", connection);
                    DataTable getyou = new DataTable();
                    sql.Fill(getyou);
                    int x = int.Parse(getyou.Rows[0]["makh"].ToString());
                    return x;
                }
                return -1;

            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
