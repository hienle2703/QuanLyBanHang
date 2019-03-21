using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DAL_KhachHang : DBConnect, IRepository<DTO_KhachHang>
    {
        public DataTable layDanhSach()
        { 
            // lấy hết
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM khachhang", connection);
            DataTable dsKhachHang = new DataTable();
            da.Fill(dsKhachHang);
            return dsKhachHang;
        }
        public bool them(DTO_KhachHang kh)
        {
            try
            {
                // Ket noi
                connection.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO khachhang(tenkh,diachi,sdt) VALUES ('{0}', '{1}', '{2}')", kh.KHACHHANG_TENKH,kh.KHACHHANG_DIACHI,kh.KHACHHANG_SDT);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, connection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;

            }
            catch
            {
                return false;
            }
            finally
            {
                // Dong ket noi
                connection.Close();
            }
        }
        public bool sua(DTO_KhachHang kh)
        {
            try
            {
                // Ket noi
                connection.Open();

                // Query string
                string SQL = string.Format("UPDATE khachhang SET  tenkh = '{0}', diachi = '{1}', sdt = '{2}' WHERE makh = {3}", kh.KHACHHANG_TENKH, kh.KHACHHANG_DIACHI, kh.KHACHHANG_SDT, kh.KHACHHANG_MAKH);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, connection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;

            }
            catch
            {
                return false;
            }
            finally
            {
                // Dong ket noi
                connection.Close();
            }
        }
        public bool xoa(int KHACHHANG_MAKH)
        {
            try
            {
                // Ket noi
                connection.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM khachhang WHERE makh = '{0}'", KHACHHANG_MAKH);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, connection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;

            }
            catch
            {
                return false;
            }
            finally
            {
                // Dong ket noi
                connection.Close();
            }
        }
        public DataTable tim (int KHACHHANG_MAKH)
        {
            MySqlDataAdapter sql =new MySqlDataAdapter( "Select * from khachhang where makh like '%" + KHACHHANG_MAKH + "%'",connection);
            DataTable dsKhachHang = new DataTable();
            sql.Fill(dsKhachHang);
            return dsKhachHang;
        }
        public DataTable tim(string KHACHHANG_TENKH)
        {
            MySqlDataAdapter sql = new MySqlDataAdapter("Select * from khachhang where tenkh like '%" + KHACHHANG_TENKH + "%'", connection);
            DataTable dsKhachHang = new DataTable();
            sql.Fill(dsKhachHang);
            return dsKhachHang;
        }

    }
}
