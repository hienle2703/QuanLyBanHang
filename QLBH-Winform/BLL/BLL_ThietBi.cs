using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ThietBi
    {
        public static DataTable hienDanhSach()
        {
            DAL.DAL_ThietBi TB = new DAL.DAL_ThietBi();
            return TB.layDanhSach();
        }
        public static DataTable tim(int ID)
        {
            DAL.DAL_ThietBi TB = new DAL.DAL_ThietBi();
            return TB.tim(ID);
        }
        public static DataTable tim(string ten)
        {
            DAL.DAL_ThietBi TB = new DAL.DAL_ThietBi();
            return TB.tim(ten);
        }
        
        
        public static DTO_ThietBi layThietBi(int ID)
        {
            DataTable dt = tim(ID);
            DTO_ThietBi TB = new DTO_ThietBi();
            TB.THIETBI_MATB = ID;
            TB.THIETBI_TEN = dt.Rows[0]["ten"].ToString();
            TB.THIETBI_GIA = (int)dt.Rows[0]["gia"];
            TB.THIETBI_SOLUONG = (int)dt.Rows[0]["soluong"];
            TB.THIETBI_THONGTINCT = dt.Rows[0]["thongtinct"].ToString();
            TB.THIETBI_TENLOAI = dt.Rows[0]["tenloai"].ToString();
            return TB;
        }
        public static bool xoa(int ID)
        {
            DAL.DAL_ThietBi TB = new DAL.DAL_ThietBi();
            return TB.xoa(ID);
        }
        public static bool them(DTO_ThietBi TB)
        {
            DAL.DAL_ThietBi DALTB = new DAL.DAL_ThietBi();
            return DALTB.them(TB);
        }
        public static bool sua(DTO_ThietBi TB)
        {
            DAL.DAL_ThietBi DALTB = new DAL.DAL_ThietBi();
            return DALTB.sua(TB);
        }
        public static bool kt(string TEN, string GIA, string SOLUONG, string THONGTINCT, string MALOAI)
        {
            if (TEN.Length == 0 || GIA.Length == 0 || SOLUONG.Length == 0 || THONGTINCT.Length == 0 || MALOAI.Length == 0)
                return true;
            return false;
        }
        public static DataTable layMaLoai()
        {
            DAL.DAL_ThietBi ML = new DAL.DAL_ThietBi();
            return ML.layMaLoai();
        }

        public static int layMaLoai(string tenloai)
        {
            DAL.DAL_ThietBi x = new DAL.DAL_ThietBi();
            return x.layMaLoai(tenloai);
        }

        public static bool ThemLoaiTB(string ten)
        {
            DAL.DAL_ThietBi tb = new DAL.DAL_ThietBi();
            return tb.themLoai(ten);
        }
        /*
public static bool layMaLoai()
{
   DAL.DAL_ThietBi DALTB = new DAL.DAL_ThietBi();
   return DALTB.layMaLoai();
}
*/
    }
}
