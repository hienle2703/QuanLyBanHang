using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using DTO;
namespace QLBH_Webform
{  
    public partial class LapHoaDon : System.Web.UI.Page
    {
        int totalPriceCCK = 0;
        int comboItemCount = 0;
        double totalPriceSauCK = 0;
        TemporaryItemTableDAL itemList = new TemporaryItemTableDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadItemBuyList();
            LoadChietKhau();
            LoadTongTien();
        }
        public void LoadItemBuyList()
        {
            DataTable result = itemList.GetItemFromTemporaryTable();
            gvSelectedItemBill.DataSource = result;
            gvSelectedItemBill.DataBind();
        }
        public void LoadTongTien()
        {
            foreach (GridViewRow row in gvSelectedItemBill.Rows)
            {
                string cost = row.Cells[2].Text;
                cost = cost.Trim(new char[] { ' ', ',', 'V', 'N', 'D' });
                totalPriceCCK += int.Parse(cost) * int.Parse(row.Cells[3].Text);
            }
            string ck = lbChietKhauValue.Text;
            ck = ck.Trim(new char[] { '%', ' ' });
            lbTongTienCCKValue.Text = totalPriceCCK.ToString() + " VND";
            LoadTongTienSauCK(totalPriceCCK, int.Parse(ck));
            totalPriceCCK = 0; //nếu không set 0 thì sau mỗi lần load lại trang là nó sẽ cộng dồn lên
        }
        public void LoadTongTienSauCK(double cost, int ck)
        {
            totalPriceSauCK = cost - cost * (ck * 1.0 / 100);
            //lbTongTienValue.Text = cost.ToString() + " - " + ck.ToString();
            lbTongTienValue.Text = totalPriceSauCK.ToString() + " VND";
        }
        public void LoadChietKhau()
        {
            comboItemCount = itemList.CountRowsOfComboItem();
            if (comboItemCount < 3)
            {
                lbChietKhauValue.Text = "0%";
            }
            if (comboItemCount >= 3 && comboItemCount < 6)
            {
                lbChietKhauValue.Text = "5%";
            }
            if (comboItemCount >= 6 && comboItemCount <= 9)
            {
                lbChietKhauValue.Text = "10%";
            }
            if (comboItemCount >= 10)
            {
                lbChietKhauValue.Text = "20%";
            }
        }
        
        // ============================EVENT===================================
        protected void rbKHThanhVien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKHThanhVien.Checked == true)
            {
                if (rbKHVangLai.Checked == true) rbKHVangLai.Checked = false;
                KhachHangDAL khachHang = new KhachHangDAL();
                DataTable result = new DataTable();
                result = khachHang.LoadDSKhachHang();
                gvKHThanhVien.DataSource = result;
                gvKHThanhVien.DataBind();
                lbTenKH.Visible = false;
                txbTenKHMoi.Visible = false;
                lbDiaChiKH.Visible = false;
                txbDiaChiKHMoi.Visible = false;
                lbSDTKH.Visible = false;
                txbSDT.Visible = false;
            }
        }
        protected void rbKHVangLai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKHVangLai.Checked == true)
            {
                if (rbKHThanhVien.Checked == true) rbKHThanhVien.Checked = false;
                gvKHThanhVien.DataSource = null;
                gvKHThanhVien.DataBind();
                lbTenKH.Visible = true;
                txbTenKHMoi.Visible = true;
                lbDiaChiKH.Visible = true;
                txbDiaChiKHMoi.Visible = true;
                lbSDTKH.Visible = true;
                txbSDT.Visible = true;                       
            }
        }

        protected void rbSelectedKH_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnTaoHoaDon_Click1(object sender, EventArgs e)
        {
            if (rbKHThanhVien.Checked == true)
            {
                //ClientScript.RegisterStartupScript(this.GetType(), "Notification", "Đã tạo hóa đơn thành công", true);
                foreach (GridViewRow row in gvKHThanhVien.Rows)
                {
                    RadioButton rbSelected = (RadioButton)row.FindControl("rbSelectedKH");
                    if (rbSelected.Checked)
                    {
                        string tienCCK = lbTongTienCCKValue.Text; tienCCK = tienCCK.Trim(new char[] { ' ', ',', 'V', 'N', 'D' });
                        string tienSCK = lbTongTienValue.Text; tienSCK = tienSCK.Trim(new char[] { ' ', ',', 'V', 'N', 'D' });
                        int chietkhau = int.Parse(tienCCK) - int.Parse(tienSCK);
                        HoaDonDAL hoadon = new HoaDonDAL();
                        hoadon.AddHoaDon(int.Parse(ngYear.Text), int.Parse(ngMonth.Text), int.Parse(ngDay.Text), int.Parse(nlpYear.Text), int.Parse(nlpMonth.Text), int.Parse(nlpDay.Text), chietkhau,int.Parse(row.Cells[0].Text));
                        DataTable lastestbill = new DataTable();
                        lastestbill = hoadon.RetrieveLastMaHD();
                        string maHD = lastestbill.Rows[0][0].ToString();
                        foreach(GridViewRow tbrow in gvSelectedItemBill.Rows)
                        {
                            hoadon.AddCTHD(int.Parse(tbrow.Cells[0].Text), int.Parse(maHD), int.Parse(tbrow.Cells[3].Text));
                        }
                        //ClientScript.RegisterStartupScript(this.GetType(), "Notification", "Đã tạo hóa đơn thành công", true);
                        /*KhachHangDTO._makh = int.Parse(row.Cells[0].Text);
                        KhachHangDTO._tenkh = row.Cells[1].Text;
                        KhachHangDTO._diachi = row.Cells[2].Text;
                        KhachHangDTO._sdt = row.Cells[3].Text;
                        string queryString = "FormHoaDon.aspx";
                        string newWin = "window.open('" + queryString + "');";
                        ClientScript.RegisterStartupScript(this.GetType(), "pop", newWin, true);*/
                    }
                }
            }
            else
            {
                KhachHangDAL addKhachHang = new KhachHangDAL();
                int maKHMoi= addKhachHang.themKHVangLai(txbTenKHMoi.Text, txbDiaChiKHMoi.Text, txbSDT.Text);
                string tienCCK = lbTongTienCCKValue.Text; tienCCK = tienCCK.Trim(new char[] { ' ', ',', 'V', 'N', 'D' });
                string tienSCK = lbTongTienValue.Text; tienSCK = tienSCK.Trim(new char[] { ' ', ',', 'V', 'N', 'D' });
                int chietkhau = int.Parse(tienCCK) - int.Parse(tienSCK);
                HoaDonDAL hoadon = new HoaDonDAL();
                hoadon.AddHoaDon(int.Parse(ngYear.Text), int.Parse(ngMonth.Text), int.Parse(ngDay.Text), int.Parse(nlpYear.Text), int.Parse(nlpMonth.Text), int.Parse(nlpDay.Text), chietkhau, maKHMoi );
                DataTable lastestbill = new DataTable();
                lastestbill = hoadon.RetrieveLastMaHD();
                string maHD = lastestbill.Rows[0][0].ToString();
                foreach (GridViewRow tbRow in gvSelectedItemBill.Rows)
                {
                    hoadon.AddCTHD(int.Parse(tbRow.Cells[0].Text), int.Parse(maHD), int.Parse(tbRow.Cells[3].Text));
                }
                ClientScript.RegisterStartupScript(this.GetType(), "Notification", "Đã tạo hóa đơn thành công", true);
            }
        }
    }
}