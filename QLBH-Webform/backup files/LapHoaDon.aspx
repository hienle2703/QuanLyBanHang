<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LapHoaDon.aspx.cs" Inherits="QLBH_WebApp.LapHoaDon" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Lập hóa đơn</h2>
    <div>
        Chọn khách hàng
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <div>
        Ngày lập phiếu:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Ngày giao hàng:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </div>
    <asp:Label ID="Label1" runat="server" Text="Danh sách sản phẩm:"></asp:Label>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Tạo hóa đơn" />
        <asp:Button ID="Button2" runat="server" Text="Tạo & xuất hóa đơn" />
        <asp:Button ID="Button3" runat="server" Text="Trở lại trang chọn sản phẩm" />
        <asp:Button ID="Button4" runat="server" Text="Xóa hết" />
        <asp:Button ID="Button5" runat="server" Text="Hủy hóa đơn" />
    </div>
</asp:Content>