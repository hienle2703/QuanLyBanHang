using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using DTO;
using System.Data;

namespace QLBH_Webform
{
    public partial class FormHoaDon : System.Web.UI.Page
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
        public void LoadInfoKhachHang()
        {
            lbMaKH.Text = KhachHangDTO._makh.ToString();
            lbTenKH.Text = KhachHangDTO._tenkh.ToString();
            lbDiaChiKH.Text = KhachHangDTO._diachi.ToString();
            lbSDT.Text = KhachHangDTO._sdt.ToString();
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
    }
}

