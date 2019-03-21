<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormHoaDon.aspx.cs" Inherits="QLBH_Webform.FormHoaDon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="text-align:center; font-size: 18px"> Chi tiết hóa đơn </h1>
        <p style="font-size: 16px"> - Thông tin khách hàng - </p>
        <asp:Label ID="lb1" runat="server" Text="Mã KH" />
        <asp:Label ID="lbMaKH" runat="server" Text="Mã KH" />
        <br />
        <asp:Label ID="lb2" runat="server" Text="Tên KH" />
        <asp:Label ID="lbTenKH" runat="server" Text="Tên KH" />
        <br />
        <asp:Label ID="lb3" runat="server" Text="Địa chỉ KH" />
        <asp:Label ID="lbDiaChiKH" runat="server" Text="Địa chỉ KH" />
        <br />
        <asp:Label ID="lb4" runat="server" Text="Số điện thoại KH" />
        <asp:Label ID="lbSDT" runat="server" Text="Số điện thoại KH" />
        <br />
    <p style="font-size: 16px"> - Thông tin đơn hàng - </p>
    <asp:GridView ID="gvSelectedItemBill" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
        ItemType="DTO.thietbiDTO" 
        CssClass="table table-striped table-bordered" >   
        <Columns>
        <asp:BoundField DataField="matb" HeaderText="Mã thiết bị" SortExpression="ProductID" />        
        <asp:BoundField DataField="ten" HeaderText="Tên thiết bị" />        
        <asp:BoundField DataField="gia" HeaderText="Giá (từng cái)" DataFormatString="{0:#} VND"/>     
        <asp:BoundField DataField="soluong" HeaderText="Số lượng mua" DataFormatString="{0:#}"/>  
        </Columns>    
    </asp:GridView>
    <strong>
        <asp:Label ID="lbTongTienCCK" runat="server" Text="Tổng tiền chưa chiết khấu: "></asp:Label>
        <asp:Label ID="lbTongTienCCKValue" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lbChietKhau" runat="server" Text="Chiết khấu: "></asp:Label>
        <asp:Label ID="lbChietKhauValue" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lbTongTien" runat="server" Text="Tổng tiền phải trả: "></asp:Label>
        <asp:Label ID="lbTongTienValue" runat="server"></asp:Label>
        <br />
    </strong>
</asp:Content>
