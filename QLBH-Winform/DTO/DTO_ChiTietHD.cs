using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHD
    {
        private int _CHITIETHD_MATB;
        private string _CHITIETHD_TENTB;
        private int _CHITIETHD_HD;
        private int _CHITIETHD_SOLUONG;
        private int _CHITIETHD_GIA;

        public int CHITIETHD_MATB { get => _CHITIETHD_MATB; set => _CHITIETHD_MATB = value; }
        public int CHITIETHD_HD { get => _CHITIETHD_HD; set => _CHITIETHD_HD = value; }
        public int CHITIETHD_SOLUONG { get => _CHITIETHD_SOLUONG; set => _CHITIETHD_SOLUONG = value; }
        public int CHITIETHD_GIA { get => _CHITIETHD_GIA; set => _CHITIETHD_GIA = value; }
        public string CHITIETHD_TENTB { get => _CHITIETHD_TENTB; set => _CHITIETHD_TENTB = value; }

        /* === Constructor === */
        public DTO_ChiTietHD()
        {

        }

        public DTO_ChiTietHD(int matb, string tentb, int mahd , int soluong, int gia)
        {
            this.CHITIETHD_MATB = matb;
            this.CHITIETHD_TENTB = tentb;
            this.CHITIETHD_HD = mahd;
            this.CHITIETHD_SOLUONG = soluong;
            this.CHITIETHD_GIA = gia;
        }
    }
}
