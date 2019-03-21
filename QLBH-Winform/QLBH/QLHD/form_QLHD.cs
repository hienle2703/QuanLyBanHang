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
    public partial class form_QLHD : Form
    {
        public form_QLHD()
        {
            InitializeComponent();
            //lấy dữ liệu từ database lên listview
            hienDanhSach();
            //cho phép click lên dòng để chọn
            list_HD.FullRowSelect = true;
        }

        private void hienDanhSach() //không tham số: hiện toàn bộ hóa đơn
        {
            hienDanhSach(BLL.BLL_HoaDon.hienDanhSach());
        }

        private void hienDanhSach(DataTable dt) //có tham số: hiện với datatable chỉ định
        {
            //xóa danh sách cũ đi
            list_HD.Items.Clear();
            list_HD.Refresh();
            //hiện
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                list_HD.Items.Add(dr["mahd"].ToString());
                list_HD.Items[i].SubItems.Add(dr["tenkh"].ToString());
                list_HD.Items[i].SubItems.Add(dr["ngaylapphieu"].ToString());
                list_HD.Items[i].SubItems.Add(dr["ngaygiao"].ToString());
                list_HD.Items[i].SubItems.Add(dr["tinhtrang"].ToString());
                ++i;
            }
        }

        private void list_HD_DoubleClick(object sender, EventArgs e)
        {
            int ID = int.Parse(list_HD.SelectedItems[0].SubItems[0].Text);
            xem(ID);
        }

        private void xem(int ID)
        {
            form_XemHD f = new form_XemHD(ID);
            f.ShowDialog();
            hienDanhSach();
        }

        private void btn_TimHD_Click(object sender, EventArgs e)
        {
            if(txt_TimHD.Text.Length==0) //không tìm gì cả => reload danh sách
            {
                hienDanhSach();
            }
            else
            if (BLL.BLL_HoaDon.ktSo(txt_TimHD.Text) == true)
            {
                DataTable dt = BLL.BLL_HoaDon.tim(int.Parse(txt_TimHD.Text));
                hienDanhSach(dt);
            }
            else
                MessageBox.Show("Mã hóa đơn phải là số","Lỗi");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_TimHD.Text = "";
            hienDanhSach();
        }

        private void btn_XemHD_Click(object sender, EventArgs e)
        {

            if (list_HD.SelectedItems.Count == 1)
                xem(int.Parse(list_HD.SelectedItems[0].SubItems[0].Text));
            else
                MessageBox.Show("Có những thứ không thể xem như màn hình khi Chương flash và thông tin hóa đơn này vì bạn chưa chọn gì để xem.");
        }
    }
}
