using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace BLL
{
    public class BLL_KhachHang
    {
        public static DataTable hienDanhSach()
        {
            DAL.DAL_KhachHang KH = new DAL.DAL_KhachHang();
            return KH.layDanhSach();
        }

        public static DataTable tim(int ID)
        {
            DAL.DAL_KhachHang KH = new DAL.DAL_KhachHang();
            return KH.tim(ID);
        }
        public static DataTable tim(string ten)
        {
            DAL.DAL_KhachHang KH = new DAL.DAL_KhachHang();
            return KH.tim(ten);
        }

        public static DTO_KhachHang layKhachHang(int ID)
        {
            DataTable dt = tim(ID);
            DTO_KhachHang KH = new DTO_KhachHang();
            KH.KHACHHANG_MAKH = ID;
            KH.KHACHHANG_TENKH = dt.Rows[0]["tenkh"].ToString();
            KH.KHACHHANG_DIACHI = dt.Rows[0]["diachi"].ToString();
            KH.KHACHHANG_SDT = dt.Rows[0]["sdt"].ToString();
            return KH;
        }

        public static bool xoa(int ID)
        {
            DAL.DAL_KhachHang KH = new DAL.DAL_KhachHang();
            return KH.xoa(ID);
        }

        public static bool them(DTO_KhachHang KH)
        {
            DAL.DAL_KhachHang DALKH = new DAL.DAL_KhachHang();
            return DALKH.them(KH);
        }

        public static bool ktRong(string x)
        {
            return (x.Length > 0);
        }

        public static bool sua(DTO_KhachHang KH)
        {
            DAL.DAL_KhachHang DALKH = new DAL.DAL_KhachHang();
            return DALKH.sua(KH);
        }

        public static bool kt(string SDT)
        {
            if (SDT.Length == 10 && SDT[0] == '0' && SDT.All(char.IsDigit))
                return true;
            return false;
        }
    }
}