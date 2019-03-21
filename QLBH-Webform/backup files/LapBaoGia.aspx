<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LapBaoGia.aspx.cs" Inherits="QLBH_WebApp.LapBaoGia" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Lập báo giá</h2>
    <div style="display:block; height: 252px; width: 1065px;">
        <div style="float:left">
            Sản phẩm<br />
            <asp:ListBox ID="ListBox1" runat="server" Height="244px" Width="205px"></asp:ListBox>
        </div>
        <div style="float:left; padding-top:100px;">
            <asp:Button ID="btn_lay" runat="server" Text="->" />
            <br />
            <asp:Button ID="btn_bo" runat="server" Text="<-" />
        </div>
        <div style="float:left">
            Đã chọn<br />
            <asp:ListBox ID="ListBox2" runat="server" Height="244px" Width="205px"></asp:ListBox>
        </div>
    </div>
    <hr />
    <asp:Label ID="Label1" runat="server" Text="Tổng tiền: "></asp:Label>
    <div>Chiết khấu: 
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <asp:Label ID="Label2" runat="server" Text="Tiền phải trả: "></asp:Label>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Lập hóa đơn" />
        <asp:Button ID="Button2" runat="server" Text="Xuất báo giá" />
        <asp:Button ID="Button3" runat="server" Text="Xóa hết" />
    </div>
</asp:Content>
