using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.QLHD
{
    public partial class form_XemHD : Form
    {
        int ID;
        public form_XemHD(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            DTO.DTO_HoaDon HD = BLL.BLL_HoaDon.layHoaDon(ID);
            txt_MaHD.Text = "Mã hóa đơn: " + ID;
            txt_HoTenKH.Text = "Khách hàng: " + HD.KHACHHANG_TENKH;
            txt_NgayLap.Text = "Ngày lập: " + HD.HOADON_NGAYLAPPHIEU;
            txt_NgayGiao.Text = "Ngày giao: " + HD.HOADON_NGAYGIAO;
            for (int i = 0; i < HD.HOADON_ChiTietHD.Count(); ++i)
            {
                listView1.Items.Add(HD.HOADON_ChiTietHD[i].CHITIETHD_TENTB);
                listView1.Items[i].SubItems.Add(HD.HOADON_ChiTietHD[i].CHITIETHD_GIA.ToString());
                listView1.Items[i].SubItems.Add(HD.HOADON_ChiTietHD[i].CHITIETHD_SOLUONG.ToString());
                listView1.Items[i].SubItems.Add((HD.HOADON_ChiTietHD[i].CHITIETHD_GIA * HD.HOADON_ChiTietHD[i].CHITIETHD_SOLUONG).ToString());
            }
            int tongTien = HD.tinhTongTien();
            txt_TongTien.Text = "Tổng tiền: " + tongTien + " VND";
            txt_GiamGia.Text = "Giảm giá: " + HD.HOADON_GIAMGIA + " VND";
            int tienTra = tongTien - HD.HOADON_GIAMGIA;
            txt_TienTra.Text = "Tiền trả: " + tienTra + " VND";
            this.hienTinhTrang(HD.HOADON_TINHTRANG);
        }

        private void hienTinhTrang(string tinhTrang)
        {
            string[] tt = {"dang xu ly", "chua xu ly", "da xu ly", "bi huy" };
            foreach(string x in tt)
                cb_TinhTrang.Items.Add(x);
            cb_TinhTrang.Text = tinhTrang;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (cb_TinhTrang.Text.Length == 0)
            {
                MessageBox.Show("Tình trạng trống", "Lỗi", MessageBoxButtons.OK);
            }
            bool kq = BLL.BLL_HoaDon.luuTinhTrang(cb_TinhTrang.Text, ID);
            if (kq == true)
                this.Close();
            else
                MessageBox.Show("Có lỗi xảy ra.", "Lỗi");
        }

        private void btn_cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
