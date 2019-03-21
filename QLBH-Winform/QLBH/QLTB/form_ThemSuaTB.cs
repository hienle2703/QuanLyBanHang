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
    public partial class form_ThemSuaTB : Form
    {
        int ID = -1;

        List<string> loaiTB = new List<string>();
        List<int> loaiTB_ID = new List<int>();
        public form_ThemSuaTB() //không tham số: thêm KH
        {
            InitializeComponent();
            loadcb();
        }

        public form_ThemSuaTB(int ID) 
        {
            InitializeComponent();
            //sửa lại giao diện một chút
            btn_accept.Text = "Thay đổi";
            this.Text = "Sửa thiết bị";
            //đưa thông tin lên textbox
            DTO.DTO_ThietBi TB = BLL.BLL_ThietBi.layThietBi(ID);
            txt_Ten.Text = TB.THIETBI_TEN;
            txt_Gia.Text = TB.THIETBI_GIA.ToString();
            txt_SoLuong.Text = TB.THIETBI_SOLUONG.ToString();
            txt_ThongTinCT.Text = TB.THIETBI_THONGTINCT;
            //local ID của class
            this.ID = ID;
            loadcb();
            cb_TenLoai.Text = TB.THIETBI_TENLOAI.ToString();
        }

        private void loadcb()
        {
            DataTable load = BLL.BLL_ThietBi.layMaLoai();
            foreach (DataRow x in load.Rows)
            {
                string s = x["tenloai"].ToString();
                cb_TenLoai.Items.Add(s);
                loaiTB_ID.Add(int.Parse(x["maloai"].ToString()));
                loaiTB.Add(s);
            }
        }

        private void btn_Cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (BLL.BLL_ThietBi.kt(txt_Ten.Text, txt_Gia.Text,txt_SoLuong.Text,txt_ThongTinCT.Text,cb_TenLoai.Text) ==true)
            
                MessageBox.Show("Có những thứ không được để trống như ví của Hiển cũng như là mấy cái linh tinh ở trên <3","Lỗi");
            
            else    
            {
                DTO.DTO_ThietBi TB = new DTO.DTO_ThietBi();
                TB.THIETBI_TEN = txt_Ten.Text;
                TB.THIETBI_GIA = Convert.ToInt32(txt_Gia.Text);
                TB.THIETBI_SOLUONG = Convert.ToInt32(txt_SoLuong.Text);
                TB.THIETBI_THONGTINCT = txt_ThongTinCT.Text;
                TB.THIETBI_TENLOAI = cb_TenLoai.Text;
                //kiểm tra loại tb tồn tại?
                int maLoai = -1;
                for (int i = 0; i < loaiTB.Count(); ++i)
                {
                    if(Equals(cb_TenLoai.Text, loaiTB[i]))
                    {
                        maLoai = loaiTB_ID[i];
                        break;
                    }
                }
                if (maLoai == -1) //không tìm ra mã loại
                {
                    DialogResult dr = MessageBox.Show("Loại thiết bị này chưa tồn tại, thêm vào cơ sở dữ liệu (Yes) hay hủy (No)?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        BLL.BLL_ThietBi.ThemLoaiTB(cb_TenLoai.Text);
                        maLoai = BLL.BLL_ThietBi.layMaLoai(cb_TenLoai.Text);
                    }
                }
                TB.THIETBI_MALOAI = maLoai;
                /////
                bool ketQua;
                if (ID == -1) //thêm
                {
                    ketQua = BLL.BLL_ThietBi.them(TB);
                }
                else //sửa
                {
                    TB.THIETBI_MATB = ID;
                    ketQua = BLL.BLL_ThietBi.sua(TB);
                }
                if (ketQua == false)
                    MessageBox.Show("Có lỗi xảy ra.", "Lỗi");
                this.Close();
            }
            
        }

        /*
        // DEMO
        private void txt_MaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
                DTO.DTO_ThietBi TB = BLL.BLL_ThietBi.layMaLoai(DTO_ThietBi);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txt_MaLoai.Items.Add(reader.GetString("id"));
                    }
        }
        //
        */
    }


    }

