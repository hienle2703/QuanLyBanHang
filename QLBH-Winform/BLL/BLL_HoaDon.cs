using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace BLL
{
    public class BLL_HoaDon
    {
        public static DataTable hienDanhSach()
        {
            DAL.DAL_HoaDon HD = new DAL.DAL_HoaDon();
            return HD.layDanhSach();
        }

        public static DataTable tim(int ID)
        {
            DAL.DAL_HoaDon HD = new DAL.DAL_HoaDon();
            return HD.tim(ID);
        }
        public static DataTable layCTHD(int ID)
        {
            DAL.DAL_HoaDon HD = new DAL.DAL_HoaDon();
            return HD.layCTHD(ID);
        }

        public static DTO_HoaDon layHoaDon(int ID)
        {
            DataTable dt = tim(ID);

            //thông tin cơ bản hóa đơn
            DTO_HoaDon HD = new DTO_HoaDon();
            HD.KHACHHANG_TENKH = dt.Rows[0]["tenkh"].ToString();
            HD.HOADON_NGAYLAPPHIEU = DateTime.Parse(dt.Rows[0]["ngaylapphieu"].ToString());
            HD.HOADON_NGAYGIAO = DateTime.Parse(dt.Rows[0]["ngaygiao"].ToString());
            HD.HOADON_TINHTRANG = dt.Rows[0]["tinhtrang"].ToString();
            HD.HOADON_GIAMGIA = int.Parse(dt.Rows[0]["giamgia"].ToString());

            //chi tiết hóa đơn
            dt = layCTHD(ID);
            foreach(DataRow dr in dt.Rows)
            {
                DTO_ChiTietHD CTHD = new DTO_ChiTietHD();

                HD.themChiTietHD(int.Parse(dr["matb"].ToString()), dr["ten"].ToString(), int.Parse(dr["soluong"].ToString()), int.Parse(dr["gia"].ToString()));
            }

            return HD;
        }

        public static bool ktSo(string text)
        {
            if (text.All(char.IsDigit))
                return true;
            return false;
        }

        public static bool luuTinhTrang(string tt, int ID)
        {
            DAL.DAL_HoaDon hd = new DAL.DAL_HoaDon();
            return hd.luuTinhTrang(tt, ID);
        }
    }
}
