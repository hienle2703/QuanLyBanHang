using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiTB
    {
        private int _LOAITB_MALOAI;
        private string _LOAITB_TENLOAI;

        public int LOAITB_MALOAI { get => _LOAITB_MALOAI; set => _LOAITB_MALOAI = value; }
        public string LOAITB_TENLOAI { get => _LOAITB_TENLOAI; set => _LOAITB_TENLOAI = value; }

        /* === Constructor === */
        public DTO_LoaiTB()
        {

        }

        public DTO_LoaiTB(int maloai, string tenloai)
        {
            this.LOAITB_MALOAI = maloai;
            this.LOAITB_TENLOAI = tenloai;
        }

        
    }
}
