using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.QLKH
{
    public partial class form_ThemSuaKH : Form
    {
        int ID = -1;
        public form_ThemSuaKH() //không tham số: thêm KH
        {
            InitializeComponent();
        }

        public form_ThemSuaKH(int ID) //có tham số ID: ID khách hàng cần sửa
        {
            InitializeComponent();
            //sửa lại giao diện một chút
            btn_accept.Text = "Thay đổi";
            //đưa thông tin lên textbox
            DTO.DTO_KhachHang KH = BLL.BLL_KhachHang.layKhachHang(ID);
            txt_Ten.Text = KH.KHACHHANG_TENKH;
            txt_DiaChi.Text = KH.KHACHHANG_DIACHI;
            txt_SDT.Text = KH.KHACHHANG_SDT;
            //local ID của class
            this.ID = ID;
        }

        private void btn_Cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (BLL.BLL_KhachHang.ktRong(txt_Ten.Text) == false || BLL.BLL_KhachHang.ktRong(txt_DiaChi.Text) == false)
                MessageBox.Show("Tên và địa chỉ không được để trống", "Lỗi");
            else
            if (BLL.BLL_KhachHang.kt(txt_SDT.Text) == false)
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi");
            else
            {
                DTO.DTO_KhachHang KH = new DTO.DTO_KhachHang();
                KH.KHACHHANG_TENKH = txt_Ten.Text;
                KH.KHACHHANG_DIACHI = txt_DiaChi.Text;
                KH.KHACHHANG_SDT = txt_SDT.Text;
                bool ketQua;
                if (ID == -1) //thêm
                {
                    ketQua = BLL.BLL_KhachHang.them(KH);
                }
                else //sửa
                {
                    KH.KHACHHANG_MAKH = ID;
                    ketQua = BLL.BLL_KhachHang.sua(KH);
                }
                if (ketQua == false)
                    MessageBox.Show("Có lỗi xảy ra.", "Lỗi");
                this.Close();
            }
        }
    }
}
