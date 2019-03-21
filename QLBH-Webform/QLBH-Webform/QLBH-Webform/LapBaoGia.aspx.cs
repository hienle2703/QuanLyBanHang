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
    public partial class LapBaoGia : System.Web.UI.Page
    {
        public DataTable comboListData = new DataTable();
        TemporaryItemTableDAL itemList = new TemporaryItemTableDAL();
        int comboItemCount = 0;
        int totalPriceCCK = 0;
        double totalPriceSauCK = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadItemType();
            comboListData.Columns.AddRange(new DataColumn[3] { new DataColumn("matb", typeof(int)), new DataColumn("ten", typeof(string)), new DataColumn("gia", typeof(int)) });
            try
            {                 
                itemList.CreateTemporaryItemTable();
            }
            catch
            {
                //do nothing
            }
            DataTable result = itemList.GetItemFromTemporaryTable();
            gvComboList.DataSource = result;
            gvComboList.DataBind();
            //chiet khau update
            LoadChietKhau();
            LoadTongTien();
        }
        //string test ="";
        public void LoadTongTien()
        {
            foreach (GridViewRow row in gvComboList.Rows)
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

        public void LoadItemType()
        {
            ItemTypeDAL itemType = new ItemTypeDAL();
            DataTable result = new DataTable();
            result = itemType.LoadIemType();
            dlItemType.DataSource = result;
            dlItemType.DataBind();
        }
        
        
        public DataTable itemInfo;
        public DataView itemInfoView;
        protected void btnTypeName_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            string itemType = btn.Text;
            ItemTypeDAL itemList = new ItemTypeDAL();
            itemInfo = (DataTable)itemList.GetItemFromItemType(itemType);
            itemInfoView = new DataView(itemInfo);
            BindListFordlItem();
        }
        public void BindListFordlItem()
        {
            dlItem.DataSource = itemInfoView;
            dlItem.DataBind();
        }
        
        // ======================== EVENT =========================
        public void dlItem_ItemCommand(Object sender, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Add")
            {
                
                dlItem.SelectedIndex = e.Item.ItemIndex;
                Label maTB = (Label)dlItem.SelectedItem.FindControl("lbMaTB");
                
                Label tenTB = (Label)dlItem.SelectedItem.FindControl("lbItemName");
                Label giaTB = (Label)dlItem.SelectedItem.FindControl("lbCost");
                Label soluongTB = (Label)dlItem.SelectedItem.FindControl("lbQuantity"); //code fake :)
                if (DAL.TemporaryItemTableDAL.tempSL >= int.Parse(soluongTB.Text.ToString()))
                {
                    return;
                }
                    itemList.AddItemToTemporaryTable(int.Parse(maTB.Text), tenTB.Text, int.Parse(giaTB.Text), int.Parse(soluongTB.Text));
                DataTable result = itemList.GetItemFromTemporaryTable();
                gvComboList.DataSource = result;
                gvComboList.DataBind();
                
            }
            LoadChietKhau();
            LoadTongTien();
        }

        protected void btnXoaComboList_Click(object sender, EventArgs e)
        {
            gvComboList.DataBind();
            itemList.DropTemporaryItemTable();
            lbChietKhauValue.Text = "0%";
            lbTongTienCCKValue.Text = "0 VND";
            lbTongTienValue.Text = "0 VND";
            //ClientScript.RegisterStartupScript(this.GetType(), "Lỗi", "alert('Đã có ComboItem');", true);
        }
        protected void btnXoaCheckedItem_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gvComboList.Rows)
            {
                CheckBox cbDel = (CheckBox)row.FindControl("Remove");
                //If CheckBox is checked than delete the record with particular empid  
                if (cbDel.Checked)
                {
                    int matb = Convert.ToInt32(row.Cells[0].Text);
                    itemList.DeleteCheckedData(matb);
                }
            }
            DataTable result = itemList.GetItemFromTemporaryTable();
            gvComboList.DataSource = result;
            gvComboList.DataBind();
            LoadChietKhau();
            LoadTongTien();
            //ClientScript.RegisterStartupScript(this.GetType(), "Lỗi", "alert('Đã có ComboItem');", true);
        }
    }
}
