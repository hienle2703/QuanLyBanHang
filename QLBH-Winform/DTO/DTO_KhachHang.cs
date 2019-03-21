using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private int _KHACHHANG_MAKH;
        private string _KHACHHANG_TENKH;
        private string _KHACHHANG_DIACHI;
        private string _KHACHHANG_SDT;

        /* ======== GETTER/SETTER ======== */
        public int KHACHHANG_MAKH
        {
            get
            {
                return _KHACHHANG_MAKH;
            }

            set
            {
                _KHACHHANG_MAKH = value;
            }
        }

        public string KHACHHANG_TENKH
        {
            get
            {
                return _KHACHHANG_TENKH;
            }

            set
            {
                _KHACHHANG_TENKH = value;
            }
        }

        public string KHACHHANG_DIACHI
        {
            get
            {
                return _KHACHHANG_DIACHI;
            }

            set
            {
                _KHACHHANG_DIACHI = value;
            }
        }

        public string KHACHHANG_SDT
        {
            get
            {
                return _KHACHHANG_SDT;
            }

            set
            {
                _KHACHHANG_SDT = value;
            }
        }

        
        /* === Constructor === */
        public DTO_KhachHang()
        {

        }

        public DTO_KhachHang(int makh, string tenkh,  string diachi, string sdt)
        {
            this.KHACHHANG_MAKH = makh;
            this.KHACHHANG_TENKH = tenkh;
            this.KHACHHANG_DIACHI = diachi;
            this.KHACHHANG_SDT = sdt;
        }
    }
}
