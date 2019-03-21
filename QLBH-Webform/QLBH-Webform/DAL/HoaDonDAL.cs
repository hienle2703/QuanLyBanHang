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
    public class HoaDonDAL : DataProvider
    {
        public DataTable AddHoaDon(int ngYear, int ngMonth, int ngDay, int nlpYear, int nlpMonth, int nlpDay, int giamGia, int maKH)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO hoadon(ngaygiao,ngaylapphieu,giamgia,makh,tinhtrang) " +
                "VALUES('"+ngYear+"-"+ngMonth+"-"+ngDay+ "','" + nlpYear + "-" + nlpMonth + "-" + nlpDay + "','" + giamGia + "','" + maKH + "','Dang Xu Ly');", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            return result;
        }
        public DataTable RetrieveLastMaHD()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT MAX(mahd) FROM hoadon;", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            return result;
        }

        public DataTable AddCTHD(int matb, int mahd, int soluong)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO chitiethd(matb,mahd,soluong) VALUES('" + matb + "','" + mahd + "','" + soluong + "');", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            return result;
        }
    }
}
