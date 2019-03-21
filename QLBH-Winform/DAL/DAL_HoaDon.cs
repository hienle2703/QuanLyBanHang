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
    public class DAL_HoaDon : DBConnect
    {
        public DataTable layDanhSach()
        {
            // lấy hết
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT mahd, tenkh, ngaylapphieu, ngaygiao, tinhtrang FROM hoadon, khachhang where hoadon.makh = khachhang.makh", connection);
            DataTable dsHoaDon = new DataTable();
            da.Fill(dsHoaDon);
            return dsHoaDon;
        }

        public bool xoa(int HOADON_MAHD)
        {
            try
            {
                // Ket noi
                connection.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM hoadon WHERE mahd = {0}", HOADON_MAHD);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, connection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch
            {

            }
            finally
            {
                // Dong ket noi
                connection.Close();
            }

            return false;
        }
        public DataTable tim(int HOADON_MAHD)
        {
            MySqlDataAdapter sql = new MySqlDataAdapter("Select * from hoadon,khachhang where mahd = '" + HOADON_MAHD + "' and hoadon.makh = khachhang.makh", connection);
            DataTable dsHoaDon = new DataTable();
            sql.Fill(dsHoaDon);
            return dsHoaDon;
        }

        public DataTable layCTHD(int HOADON_MAHD)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT thietbi.matb, ten, gia, chitiethd.soluong FROM chitiethd, hoadon, thietbi where chitiethd.mahd = hoadon.mahd AND hoadon.mahd = '"+ HOADON_MAHD + "' AND chitiethd.matb = thietbi.matb", connection);
            DataTable dsHoaDon = new DataTable();
            da.Fill(dsHoaDon);
            return dsHoaDon;
        }
        
        public bool luuTinhTrang(string tt, int ID)
        {
            try
            {
                // Ket noi
                connection.Open();

                // Query string
                string SQL = string.Format("UPDATE hoadon SET tinhtrang = '{0}' WHERE mahd = {1}", tt, ID);

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
    }
}
