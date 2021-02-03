<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Admin.master" AutoEventWireup="true" CodeFile="QuanLyNguoiDung.aspx.cs" Inherits="QuanLyNguoiDung" %>

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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellspacing="1" class="style3" 
        style="padding-right: 150px; padding-left: 150px" width="100%">
        <tr>
            <td align="center" class="style4" colspan="2" 
                style="background-color: #339933; font-weight: bold;">
                QUẢN LÝ NGƯỜI DÙNG</td>
        </tr>
        <tr>
            <td class="style5">
                ID:</td>
            <td>
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                Tên đăng nhập:</td>
            <td>
                <asp:TextBox ID="txtTenDangNhap" runat="server" Width="290px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                Mật khẩu:</td>
            <td>
                <asp:TextBox ID="txtMatKhau" runat="server" Width="289px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
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
                    BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
                    CellPadding="2" EnableModelValidation="True" ForeColor="Black" GridLines="None" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" Width="100%">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" />
                        <asp:BoundField DataField="TenDangNhap" HeaderText="Tên đăng nhập" />
                        <asp:BoundField DataField="MatKhau" HeaderText="Mật khẩu" />
                        <asp:CommandField SelectText="Chọn" ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="Tan" />
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                        HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

