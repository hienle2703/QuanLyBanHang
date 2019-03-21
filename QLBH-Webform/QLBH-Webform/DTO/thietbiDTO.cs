using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class thietbiDTO
    {
        private int _maTB;
        private string _ten;
        private int _gia;
        private int _soLuong;
        private string _thongtinct;
        private int _maLoai;

        public int MaTB { get => _maTB; set => _maTB = value; }
        public string Ten { get => _ten; set => _ten = value; }
        public int Gia { get => _gia; set => _gia = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public string Thongtinct { get => _thongtinct; set => _thongtinct = value; }
        public int MaLoai { get => _maLoai; set => _maLoai = value; }
        public thietbiDTO()
        { }
        public thietbiDTO(int matb, string ten, int gia, int soluong, string thongtinct, int maloai)
        {
            this.MaTB = matb;
            this.Ten = ten;
            this.Gia = gia;
            this.SoLuong = soluong;
            this.Thongtinct = thongtinct;
            this.MaLoai = maloai;
        }
        public thietbiDTO(int matb, string ten, int gia)
        {
            this.MaTB = matb;
            this.Ten = ten;
            this.Gia = gia;
        }
    }
    
}
