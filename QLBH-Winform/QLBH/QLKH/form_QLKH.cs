using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.QLKH;

namespace QLBH
{
    public partial class form_QLKH : Form
    {
        public form_QLKH()
        {
            InitializeComponent();
            //lấy dữ liệu từ database lên listview
            hienDanhSach();
            //cho phép click lên dòng để chọn
            list_KH.FullRowSelect = true;
        }

        private void hienDanhSach() //không tham số: hiện toàn bộ khách hàng
        {
            hienDanhSach(BLL.BLL_KhachHang.hienDanhSach());
        }

        private void hienDanhSach(DataTable dt) //có tham số: hiện với datatable chỉ định
        {
            //xóa danh sách cũ đi
            list_KH.Items.Clear();
            list_KH.Refresh();
            //hiện
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                list_KH.Items.Add(dr["makh"].ToString());
                list_KH.Items[i].SubItems.Add(dr["tenkh"].ToString());
                list_KH.Items[i].SubItems.Add(dr["diachi"].ToString());
                list_KH.Items[i].SubItems.Add(dr["sdt"].ToString());
                ++i;
            }
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            form_ThemSuaKH f = new form_ThemSuaKH();
            f.ShowDialog();
            hienDanhSach();
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            if (list_KH.SelectedItems.Count == 1)
                sua(int.Parse(list_KH.SelectedItems[0].SubItems[0].Text));
            else
                MessageBox.Show("Có những thứ không thể sửa như nhân cách của Chương và thông tin khách hàng này vì bạn chưa chọn gì để sửa.");
        }

        private void list_KH_DoubleClick(object sender, EventArgs e)
        {
            int ID = int.Parse(list_KH.SelectedItems[0].SubItems[0].Text);
            sua(ID);
        }

        private void sua(int ID)
        {
            form_ThemSuaKH f = new form_ThemSuaKH(ID);
            f.ShowDialog();
            hienDanhSach();
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            if (list_KH.SelectedItems.Count == 1)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if(dr==DialogResult.Yes)
                {
                    bool ketqua = BLL.BLL_KhachHang.xoa(int.Parse(list_KH.SelectedItems[0].SubItems[0].Text));
                    if (ketqua == true)
                        hienDanhSach();
                    else
                        MessageBox.Show("Không thể xóa.", "Lỗi");
                }
            }
            else
                MessageBox.Show("Có những thứ không thể xóa như người yêu của Huy và khách hàng này vì không có gì để xóa.");
        }

        private void btn_TimKH_Click(object sender, EventArgs e)
        {
            /*if(txt_TimKH.Text.Length==0) //không tìm gì cả => reload danh sách
            {
                hienDanhSach();
            }*/
            DataTable dt = BLL.BLL_KhachHang.tim(txt_TimKH.Text);
            hienDanhSach(dt);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_TimKH.Text = "";
            hienDanhSach();
        }
    }
}
