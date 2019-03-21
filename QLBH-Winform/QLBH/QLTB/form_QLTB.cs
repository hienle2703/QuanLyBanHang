using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.QLTB
{
    public partial class form_QLTB : Form
    {
        public form_QLTB()
        {
            InitializeComponent();
            hienDanhSach();
            //cho phép click lên dòng để chọn
            list_TB.FullRowSelect = true;
        }
        private void hienDanhSach()
        {
            hienDanhSach(BLL.BLL_ThietBi.hienDanhSach());
        }
        private void hienDanhSach(DataTable dt) //có tham số: hiện với datatable chỉ định
        {
            //xóa danh sách cũ đi
            list_TB.Items.Clear();
            list_TB.Refresh();
            //hiện
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                list_TB.Items.Add(dr["matb"].ToString());
                list_TB.Items[i].SubItems.Add(dr["ten"].ToString());
                list_TB.Items[i].SubItems.Add(dr["gia"].ToString());
                list_TB.Items[i].SubItems.Add(dr["tenloai"].ToString());
                list_TB.Items[i].SubItems.Add(dr["soluong"].ToString());
                list_TB.Items[i].SubItems.Add(dr["thongtinct"].ToString());
                ++i;
            }
        }
        private void btn_ThemTB_Click(object sender, EventArgs e)
        {
            form_ThemSuaTB f = new form_ThemSuaTB();
            f.ShowDialog();
            hienDanhSach();
        }
        
        private void btn_SuaTB_Click(object sender, EventArgs e)
        {
            if (list_TB.SelectedItems.Count == 1)
                sua(int.Parse(list_TB.SelectedItems[0].SubItems[0].Text));
            else
                MessageBox.Show("Có những thứ không thể sửa như nhân cách của Chương và thông tin thiết bị này vì bạn chưa chọn gì để sửa.");
        }
        private void list_TB_DoubleClick(object sender, EventArgs e)
        {
            int ID = int.Parse(list_TB.SelectedItems[0].SubItems[0].Text);
            sua(ID);
        }
        private void sua(int ID)
        {
            form_ThemSuaTB f = new form_ThemSuaTB(ID);
            f.ShowDialog();
            hienDanhSach();
        }
        private void btn_XoaTB_Click(object sender, EventArgs e)
        {
            if (list_TB.SelectedItems.Count == 1)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bool ketqua = BLL.BLL_ThietBi.xoa(int.Parse(list_TB.SelectedItems[0].SubItems[0].Text));
                    if (ketqua == true)
                        hienDanhSach();
                    else
                        MessageBox.Show("Không thể xóa.", "Lỗi");
                }
            }
            else
                MessageBox.Show("Có những thứ không thể xóa như người yêu của Huy và khách hàng này vì không có gì để xóa.");
        }
        private void btn_TimTB_Click(object sender, EventArgs e)
        {
            DataTable dt = BLL.BLL_ThietBi.tim(txt_TimTB.Text);
            hienDanhSach(dt);
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_TimTB.Text = "";
            hienDanhSach();
        }

        
    }
}
