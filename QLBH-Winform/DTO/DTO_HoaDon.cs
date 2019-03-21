using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private int _HOADON_MAHD;
        private DateTime _HOADON_NGAYGIAO;
        private DateTime _HOADON_NGAYLAPPHIEU;
        private int _HOADON_MAKH;
        private string _KHACHHANG_TENKH;
        private string _HOADON_TINHTRANG;
		List<DTO_ChiTietHD> _HOADON_ChiTietHD = new List<DTO_ChiTietHD>();
        int _HOADON_GIAMGIA;

        public int HOADON_MAHD { get => _HOADON_MAHD; set => _HOADON_MAHD = value; }
        public DateTime HOADON_NGAYGIAO { get => _HOADON_NGAYGIAO; set => _HOADON_NGAYGIAO = value; }
        public DateTime HOADON_NGAYLAPPHIEU { get => _HOADON_NGAYLAPPHIEU; set => _HOADON_NGAYLAPPHIEU = value; }
        public int HOADON_MAKH { get => _HOADON_MAKH; set => _HOADON_MAKH = value; }
        public string HOADON_TINHTRANG { get => _HOADON_TINHTRANG; set => _HOADON_TINHTRANG = value; }
        public List<DTO_ChiTietHD> HOADON_ChiTietHD { get => _HOADON_ChiTietHD; set => _HOADON_ChiTietHD = value; }
        public string KHACHHANG_TENKH { get => _KHACHHANG_TENKH; set => _KHACHHANG_TENKH = value; }
        public int HOADON_GIAMGIA { get => _HOADON_GIAMGIA; set => _HOADON_GIAMGIA = value; }



        /* === Constructor === */
        public DTO_HoaDon()
        {

        }

        public DTO_HoaDon(int mahd, DateTime ngaygiao, DateTime ngaylapphieu, int makh, string tinhtrang)
        {
            this.HOADON_MAHD = mahd;
            this.HOADON_NGAYGIAO = ngaygiao;
            this.HOADON_NGAYLAPPHIEU = ngaylapphieu;
            this.HOADON_MAKH = makh;
            this.HOADON_TINHTRANG = tinhtrang;
        }

		public void themChiTietHD(DTO_ChiTietHD cthd)
		{
			_HOADON_ChiTietHD.Add(cthd);
		}
        
		public void themChiTietHD(int MaTB, string TenTB, int SoLuong, int Gia)
		{
			DTO_ChiTietHD cthd = new DTO_ChiTietHD(MaTB, TenTB, _HOADON_MAHD, SoLuong, Gia);
			_HOADON_ChiTietHD.Add(cthd);
		}
		
        public int tinhTongTien()
        {
            int tong = 0;
            for(int i=0;i<HOADON_ChiTietHD.Count();++i)
            {
                tong += HOADON_ChiTietHD[i].CHITIETHD_GIA * HOADON_ChiTietHD[i].CHITIETHD_SOLUONG;
            }
            return tong;
        }
    }
}
