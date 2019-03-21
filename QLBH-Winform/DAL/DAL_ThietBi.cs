using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class DAL_ThietBi : DBConnect, IRepository<DTO_ThietBi>
    {
        public DataTable layDanhSach()
        {
            // lấy hết
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM thietbi, loaitb where thietbi.maloai = loaitb.maloai", connection);
            DataTable dsThietBi = new DataTable();
            da.Fill(dsThietBi);
            return dsThietBi;
        }
        public bool them(DTO_ThietBi tb)
        {
            try
            {
                // Ket noi
                connection.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO thietbi(ten,gia,soluong,thongtinct,maloai) VALUES ('{0}', '{1}', '{2}','{3}','{4}')", tb.THIETBI_TEN, tb.THIETBI_GIA, tb.THIETBI_SOLUONG, tb.THIETBI_THONGTINCT, tb.THIETBI_MALOAI);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, connection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

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

            return false;
        }
        
        public bool sua(DTO_ThietBi tb)
        {
            try
            {
                // Ket noi
                connection.Open();

                // Query string
                string SQL = string.Format("UPDATE thietbi SET  ten = '{0}', gia = '{1}', soluong = '{2}' , thongtinct = '{3}' , maloai= {4} WHERE matb = {5}", tb.THIETBI_TEN, tb.THIETBI_GIA, tb.THIETBI_SOLUONG, tb.THIETBI_THONGTINCT, tb.THIETBI_MALOAI,tb.THIETBI_MATB);

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

        public bool themLoai(string ten)
        {
            try
            {
                // Ket noi
                connection.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO loaitb(tenloai) VALUES ('{0}')", ten);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, connection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else return false;

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

        public bool xoa(int THIETBI_MATB)
        {
            try
            {
                // Ket noi
                connection.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM thietbi WHERE matb = {0}", THIETBI_MATB);

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
        
        public DataTable tim(int THIETBI_MATB)
        {
            MySqlDataAdapter sql = new MySqlDataAdapter("Select * from thietbi, loaitb where matb = '" + THIETBI_MATB + "' and thietbi.maloai = loaitb.maloai", connection);
            DataTable dsThietBi = new DataTable();
            sql.Fill(dsThietBi);
            return dsThietBi;
        }
        public DataTable tim(string THIETBI_TEN)
        {
            MySqlDataAdapter sql = new MySqlDataAdapter("Select * from thietbi, loaitb where ten like '%" + THIETBI_TEN + "%' and thietbi.maloai = loaitb.maloai", connection);
            DataTable dsThietBi = new DataTable();
            sql.Fill(dsThietBi);
            return dsThietBi;
        }
        public DataTable layMaLoai()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM loaitb",connection);
            DataTable dsMaLoai = new DataTable();
            da.Fill(dsMaLoai);
            return dsMaLoai;
        }

        public int layMaLoai(string ten)
        {
            MySqlDataAdapter sql = new MySqlDataAdapter("select maloai from loaitb where tenloai = '" + ten + "'", connection);
            DataTable dsThietBi = new DataTable();
            sql.Fill(dsThietBi);
            int x = int.Parse(dsThietBi.Rows[0]["maloai"].ToString());
            return x;
        }

        /*
        public bool layMaLoai(DTO_ThietBi tb)
        {
            try
            {
                // Ket noi
                connection.Open();
                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("SELECT maloai,tenloai FROM thietbi,loaitb WHERE thietbi.maloai =  loaitb.maloai");
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, connection);
                var reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
            }
            finally
            {
                // Dong ket noi
                connection.Close();
            }
            return false;
        }
        */

    }
}
