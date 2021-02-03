<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCC_AllSachDataList.ascx.cs" Inherits="UCC_AllSachDataList" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 106px;
    }
    .style3
    {
        color: rgb(255, 0, 0);
        background-color: #FFFFCC;
    }
</style>

<asp:DataList ID="DataList1" runat="server" Width="100%" BackColor="#FFFFC0" 
    RepeatColumns="3">
    <ItemTemplate>
        <table cellspacing="1" class="style1">
            <tr>
                <td class="style2" rowspan="3">
                    <asp:Image ID="Image1" runat="server" Height="101px" 
                        ImageUrl='<%# "~/Images/" + Eval("TenFileAnh") %>' Width="101px" />
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl='<%# "ChiTietSach.aspx?MaSach=" + Eval("MaSach") %>' 
                        Text='<%# Eval("TenSach") %>' Font-Underline="False"></asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Nhà Sản Xuất: </strong>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("TacGia") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Giá bán: </strong>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Gia") %>' 
                        style="color: #FF0000; font-weight: 700"></asp:Label>
                    <span class="style3" 
                        style="font-family: Arial, sans-serif; font-size: 22px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">
                    ₫</span></td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>

