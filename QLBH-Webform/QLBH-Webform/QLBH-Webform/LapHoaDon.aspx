<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LapHoaDon.aspx.cs" Inherits="QLBH_Webform.LapHoaDon" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:RadioButtonList ID="SelectedKHGN" runat="server"></asp:RadioButtonList>
    <h2>Lập hóa đơn</h2>
    <div style="width: 50%; float:left">
        <div>
            Chọn khách hàng
            <asp:RadioButton ID="rbKHThanhVien" runat="server" AutoPostBack="true" Text="Khách hàng thành viên" OnCheckedChanged="rbKHThanhVien_CheckedChanged" />
            <asp:RadioButton ID="rbKHVangLai" Text="Khách hàng vãng lai" runat="server" AutoPostBack="true" OnCheckedChanged="rbKHVangLai_CheckedChanged"  />
            <asp:GridView ID="gvKHThanhVien" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
                ItemType="DTO.KhachHangDTO" 
                CssClass="table table-striped table-bordered" >
                <Columns>
                <asp:BoundField DataField="makh" HeaderText="Mã khách hàng" SortExpression="ProductID" />        
                <asp:BoundField DataField="tenkh" HeaderText="Tên khách hàng" />        
                <asp:BoundField DataField="diachi" HeaderText="Địa chỉ"/>     
                <asp:BoundField DataField="sdt" HeaderText="Số điện thoại"/>   
                <asp:TemplateField HeaderText="Chọn Khách hàng">            
                    <ItemTemplate>
                        <asp:RadioButton id="rbSelectedKH" GroupName="SelectedKHGN" runat="server"></asp:RadioButton>
                    </ItemTemplate>        
                </asp:TemplateField>    
                </Columns>    
            </asp:GridView>
            <asp:Label ID="lbTenKH" runat="server" Text="Tên KH" />
            <asp:TextBox runat="server" ID="txbTenKHMoi" />
            <br />
            <asp:Label ID="lbDiaChiKH" runat="server" Text="Địa chỉ KH" />
            <asp:TextBox runat="server" ID="txbDiaChiKHMoi" />
            <br />
            <asp:Label ID="lbSDTKH" runat="server" Text="Số điện thoại KH" />
            <asp:TextBox runat="server" ID="txbSDT" />
            <br />
        </div>
        <div>
            Ngày lập phiếu (dd-mm-yyyy):
            <asp:TextBox ID="nlpDay" runat="server" Width="28px"></asp:TextBox>
            <asp:TextBox ID="nlpMonth" runat="server" Width="28px"></asp:TextBox>
            <asp:TextBox ID="nlpYear" runat="server" Width="58px"></asp:TextBox>
            <br />
            Ngày giao hàng (dd-mm-yyyy):
            <asp:TextBox ID="ngDay" runat="server" Width="28px"></asp:TextBox>
            <asp:TextBox ID="ngMonth" runat="server" Width="28px"></asp:TextBox>
            <asp:TextBox ID="ngYear" runat="server" Width="53px"></asp:TextBox>
        </div>
    </div>
    <div style="width: 45%; float:left; margin-left: 50px;">
        <asp:Label ID="Label1" runat="server" Text="Danh sách sản phẩm:"></asp:Label>
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
        <div>
            <asp:LinkButton ID="btnTaoHoaDon" runat="server" Text="Tạo hóa đơn" OnClick="btnTaoHoaDon_Click1" />
            <asp:Button ID="Button3" runat="server" Text="Trở lại trang chọn sản phẩm" PostBackUrl="~/LapBaoGia.aspx" />
        </div>
    </div>
    <script type="text/javascript">
        $("#MainContent_btnTaoHoaDon").click(function () {
            alert("Đã tạo hóa đơn thành công <3 <3 <3");
        });

    </script>
    <!--<script type="text/javascript">
        $('input:radio[value="rbSelectedKH"]').attr("name", "selectedKH");
        function CheckOtherIsCheckedByGVID(rb) {
        var isChecked = rb.checked;
        var row = rb.parentNode.parentNode;
        if (isChecked) {
            row.style.backgroundColor = '#B6C4DE';
            row.style.color = 'black';
        }
        var currentRdbID = rb.id;
        parent = document.getElementById("<= gvKHThanhVien.ClientID %>");
        var items = parent.getElementsByTagName('input');

        for (i = 0; i < items.length; i++) {
            if (items[i].id != currentRdbID && items[i].type == "radio") {
                if (items[i].checked) {
                    items[i].checked = false;
                    items[i].parentNode.parentNode.style.backgroundColor = 'white';
                    items[i].parentNode.parentNode.style.color = '#696969';
                }
            }
        }
}
    </script>-->
    
</asp:Content>