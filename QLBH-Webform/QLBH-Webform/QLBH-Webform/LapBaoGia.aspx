<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LapBaoGia.aspx.cs" Inherits="QLBH_Webform.LapBaoGia" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="align-content: center; text-align: center"> CỬA HÀNG LINH KIỆN MÁY TÍNH ARESVN</h2>
    <div style="display:block; height: 1000px; width: 100%; float: left">
        <div style="float:left; font-size: 16px; font-weight: bold; width: 20%">
            LOẠI SẢN PHẨM <br />
            <asp:DataList ID="dlItemType" runat="server" Width="150px">
                <ItemTemplate>
                    <table style='width: 100%;border: solid 1px;padding: 5px;text-align: center;'>   
                        <tr>
                            <td style="text-align:center">
                                <asp:LinkButton ID="btnTypeName" runat="server" Text='<%# Eval("tenloai") %>' Width="140px" OnClick="btnTypeName_Click"/>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
        <div style="float:left;font-size: 16px; margin-left: 3px; font-weight: bold; width: 50%">
            DANH SÁCH SẢN PHẨM
            <asp:DataList ID="dlItem" runat="server" RepeatColumns = "3" CellSpacing = "1" RepeatLayout = "Table" OnItemCommand="dlItem_ItemCommand">
                <ItemTemplate>
                    <table style='width: 50%; padding: 10px; box-shadow: 3px 4px 6px 4px #888888; float: left; margin: 20px'>
                        <tr>
                            <td style="text-align: center; font-weight: bold; font-size: 18px">
                                <asp:Label ID="lbItemName" runat="server" Text='<%# Eval("ten") %>'></asp:Label>
                            </td>
                        </tr>    
                        <tr>
                            <td style="padding-left: 10px; font-size: 14px"> Mã: 
                                <asp:Label ID="lbMaTB" runat="server" Text='<%#Eval("matb") %>'></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td style="padding-left: 10px; font-size: 14px"> Giá: 
                                <asp:Label ID="lbCost" runat="server" Text='<%# Eval("gia") %>'></asp:Label> VND
                            </td>
                        </tr>  
                        <tr>
                            <td style="padding-left: 10px; font-size: 14px"> Số lượng: 
                                <asp:Label ID="lbQuantity" runat="server" Text=' <%# Eval("soluong") %>'></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td style="text-align: center; font-size: 14px; margin: 5px;">
                                <asp:LinkButton ID="btnAddToCombo" runat="server" Text="Thêm vào combo" Width="140px" CommandName="Add" />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
        <div style="float: left; width: 28%;margin: 5px;">
            <div>
                <p style="font-weight: bold; font-size: 18px">Danh sách combo </p>
            <asp:GridView ID="gvComboList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
                ItemType="DTO.thietbiDTO" 
                CssClass="table table-striped table-bordered" >   
                <Columns>
                <asp:BoundField DataField="matb" HeaderText="Mã thiết bị" SortExpression="ProductID" />        
                <asp:BoundField DataField="ten" HeaderText="Tên thiết bị" />        
                <asp:BoundField DataField="gia" HeaderText="Giá (từng cái)" DataFormatString="{0:#} VND"/>     
                <asp:BoundField DataField="soluong" HeaderText="Số lượng mua" DataFormatString="{0:#}"/> 
                <asp:TemplateField HeaderText="Xóa khỏi combo">            
                        <ItemTemplate>
                            <asp:CheckBox id="Remove" runat="server"></asp:CheckBox>
                        </ItemTemplate>        
                </asp:TemplateField>    
                </Columns>    
            </asp:GridView>
                <asp:Button ID="btnXoaCheckedItem" runat="server" Text="Xóa mục đã chọn" OnClick="btnXoaCheckedItem_Click" />
                <asp:Button ID="btnXoaComboList" runat="server" Text="Xóa tất cả" OnClick="btnXoaComboList_Click" />
                <p></p>
                <strong>
                    <asp:Label ID="lbTongTienCCK" runat="server" Text="Tổng tiền chưa chiết khấu: "></asp:Label>
                    <asp:Label ID="lbTongTienCCKValue" runat="server" Text="0 VND"></asp:Label>
                    <br />
                    <asp:Label ID="lbChietKhau" runat="server" Text="Chiết khấu: "></asp:Label>
                    <asp:Label ID="lbChietKhauValue" runat="server" Text="0%"></asp:Label>
                    <br />
                    <asp:Label ID="lbTongTien" runat="server" Text="Tổng tiền phải trả: "></asp:Label>
                    <asp:Label ID="lbTongTienValue" runat="server" Text="0 VND"></asp:Label>
                    <br />
                </strong> 
                <br />
                <p style="font-weight: bold; font-size: 14px">*Phương thức tính combo:</p>
                <p style=" font-size: 14px">-Mua từ 3 đến 5 sản phẩm sẽ được giảm 5% trên tổng giá trị đơn hàng</p>
                <p style="font-size:14px">-Mua từ 6 đến 9 sản phẩm sẽ được giảm giá 10% trên tổng giá trị đơn hàng </p>
                <p style="font-size:14px">-Mua từ 10 sản phẩm trở lên sẽ được giảm giá 20% trên tổng giá trị đơn hàng</p>
                <asp:Button ID="btnLapHoaDon" runat="server" Text="Lập hóa đơn" PostBackUrl="~/LapHoaDon.aspx"/>               
            </div>
    <br />
        </div>
    </div>
            
    

<%--    
    <script type="text/javascript">
         $(document).ready(function()
         {
             $('#btLapHoaDon').click(function() 
             {
                 Window.location.href = "LapHoaDon.aspx";
             });
         });
    </script>--%>
</asp:Content>

