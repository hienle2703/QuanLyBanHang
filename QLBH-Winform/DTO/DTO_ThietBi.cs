using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThietBi
    {
        private int _THIETBI_MATB;
        private string _THIETBI_TEN;
        private int _THIETBI_GIA;
        private int _THIETBI_SOLUONG;
        private string _THIETBI_THONGTINCT;
        private int _THIETBI_MALOAI;
        private string _THIETBI_TENLOAI;

        /* ======== GETTER/SETTER ======== */
        public int THIETBI_MATB
        {
            get
            {
                return _THIETBI_MATB;
            }

            set
            {
                _THIETBI_MATB = value;
            }
        }

        public string THIETBI_TEN
        {
            get
            {
                return _THIETBI_TEN;
            }

            set
            {
                _THIETBI_TEN = value;
            }
        }

        public int THIETBI_GIA
        {
            get
            {
                return _THIETBI_GIA;
            }

            set
            {
                _THIETBI_GIA = value;
            }
        }

        public int THIETBI_SOLUONG
        {
            get
            {
                return _THIETBI_SOLUONG;
            }

            set
            {
                _THIETBI_SOLUONG = value;
            }
        }

        public string THIETBI_THONGTINCT
        {
            get
            {
                return _THIETBI_THONGTINCT;
            }

            set
            {
                _THIETBI_THONGTINCT = value;
            }
        }

        public int THIETBI_MALOAI
        {
            get
            {
                return _THIETBI_MALOAI;
            }

            set
            {
                _THIETBI_MALOAI = value;
            }
        }

        public string THIETBI_TENLOAI { get => _THIETBI_TENLOAI; set => _THIETBI_TENLOAI = value; }

        /* === Constructor === */
        public DTO_ThietBi()
        {

        }

        public DTO_ThietBi(int matb, string ten, int gia, int soluong,string thongtinct,int maloai)
        {
            this.THIETBI_MATB = matb;
            this.THIETBI_TEN = ten;
            this.THIETBI_GIA = gia;
            this.THIETBI_SOLUONG = soluong;
            this.THIETBI_THONGTINCT = thongtinct;
            this.THIETBI_MALOAI = maloai;
        }
    }
}
