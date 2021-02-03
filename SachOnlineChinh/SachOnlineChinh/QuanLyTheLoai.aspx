<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Admin.master" AutoEventWireup="true" CodeFile="QuanLyTheLoai.aspx.cs" Inherits="QuanLyTheLoai" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
        }
        .style4
        {
            height: 25px;
        }
        .style5
        {
        }
        .auto-style1 {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellspacing="1" class="style3" 
        style="padding-right: 150px; padding-left: 150px;" width="100%">
        <tr>
            <td align="center" class="style4" colspan="2" 
                style="background-color: #339933; font-weight: bold; color: #FFFFFF;">
                QUẢN LÝ THỂ LOẠI SẢN PHẨM</td>
        </tr>
        <tr>
            <td class="style5">
                Mã Sách:</td>
            <td>
                <asp:TextBox ID="txtMaLoai" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                Loại Sách:</td>
            <td>
                <asp:TextBox ID="txtTenLoai" runat="server" Width="311px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                </td>
            <td class="auto-style1">
                </td>
        </tr>
        <tr>
            <td align="center" class="style5" colspan="2">
                <asp:Button ID="cmdThem" runat="server" onclick="cmdThem_Click" Text="Thêm" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="cmdXoa" runat="server" onclick="cmdXoa_Click" Text="Xóa" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="cmdSua" runat="server" onclick="cmdSua_Click" Text="Sửa" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="cmdGhi" runat="server" onclick="cmdGhi_Click" Text="Ghi" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="cmdKhongGhi" runat="server" onclick="cmdKhongGhi_Click" 
                    Text="Không ghi" />
            </td>
        </tr>
        <tr>
            <td align="center" class="style5" colspan="2">
                <asp:Label ID="lblThongBao" runat="server" ForeColor="#CC3300" Text="Label"></asp:Label>
&nbsp;&nbsp;
                <asp:Button ID="cmdCo" runat="server" onclick="cmdCo_Click" Text="Có" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="cmdKhong" runat="server" onclick="cmdKhong_Click" 
                    Text="Không" />
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5" colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" EnableModelValidation="True" GridLines="Vertical" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" Width="100%" 
                    DataKeyNames="MaLoai">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:BoundField DataField="MaLoai" HeaderText="Mã loại" />
                        <asp:BoundField DataField="TenLoai" HeaderText="Tên loại" />
                        <asp:CommandField SelectText="Chọn" ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </td>
        </tr>
    </table>

</asp:Content>

