<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Admin.master" AutoEventWireup="true" CodeFile="QuanLySach.aspx.cs" Inherits="QuanLySach" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
        }
        .style4
        {
            width: 280px;
        }
        .style5
        {
            width: 122px;
        }
        .style6
        {
        }
        .style7
        {
            width: 65px;
            height: 14px;
        }
        .style11
        {
            height: 14px;
        }
        .style12
        {
            width: 280px;
            height: 14px;
        }
        .style13
        {
            width: 122px;
            height: 14px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellspacing="1" class="style3" width="100%">
        <tr>
            <td align="center" colspan="4" 
                style="background-color: #339933; font-weight: bold; color: #FFFFFF;">
                QUẢN LÝ SẢN PHẨM</td>
        </tr>
        <tr>
            <td class="style6">
                Mã sản phẩm:</td>
            <td class="style4">
                <asp:TextBox ID="txtMaSach" runat="server"></asp:TextBox>
            </td>
            <td class="style5">
                Chọn ảnh sản phẩm:</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="btnUploadAnh" runat="server" onclick="btnUploadAnh_Click" 
                    Text="Upload ảnh" />
            </td>
        </tr>
        <tr>
            <td class="style6">
                Tên Sách:</td>
            <td class="style4">
                <asp:TextBox ID="txtTenSach" runat="server" Width="268px"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:Label ID="lblAnhSach" runat="server" Text="Ảnh sản phẩm:"></asp:Label>
            </td>
            <td rowspan="5">
                <asp:Image ID="imgSach" runat="server" Height="167px" Width="134px" />
            </td>
        </tr>
        <tr>
            <td class="style6">
                Nhà sản xuất:</td>
            <td class="style4">
                <asp:TextBox ID="txtTacGia" runat="server" Width="266px"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:TextBox ID="txtTenFileAnh" runat="server" Width="81px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Giá:</td>
            <td class="style4">
                <asp:TextBox ID="txtGia" runat="server"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                Số lượng:</td>
            <td class="style4">
                <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                Mô tả:</td>
            <td class="style4">
                <asp:TextBox ID="txtMoTa" runat="server" Rows="4" TextMode="MultiLine" 
                    Width="268px"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                Mã loại:</td>
            <td class="style4">
                <asp:TextBox ID="txtMaLoai" runat="server"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11">
            </td>
            <td class="style12">
            </td>
            <td class="style13">
            </td>
            <td class="style11">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="4">
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
            <td align="center" colspan="4">
                <asp:Label ID="lblThongBao" runat="server" ForeColor="#CC3300" Text="Label"></asp:Label>
&nbsp;&nbsp;
                <asp:Button ID="cmdCo" runat="server" onclick="cmdCo_Click" Text="Có" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="cmdKhong" runat="server" onclick="cmdKhong_Click" 
                    Text="Không" />
            </td>
        </tr>
        <tr>
            <td class="style7">
            </td>
            <td class="style12">
            </td>
            <td class="style13">
            </td>
            <td class="style11">
            </td>
        </tr>
        <tr>
            <td class="style6" colspan="4">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
                    CellPadding="2" DataKeyNames="MaSach" EnableModelValidation="True" 
                    ForeColor="Black" GridLines="None" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" Width="100%">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:BoundField DataField="MaSach" HeaderText="Mã sản phẩm" />
                        <asp:BoundField DataField="TenSach" HeaderText="Tên sản phẩm" />
                        <asp:BoundField DataField="TacGia" HeaderText="Nhà sản xuất" />
                        <asp:BoundField DataField="Gia" HeaderText="Giá" />
                        <asp:BoundField DataField="SoLuong" HeaderText="Số lượng" />
                        <asp:BoundField DataField="MoTa" HeaderText="Mô tả" />
                        <asp:BoundField DataField="TenFileAnh" HeaderText="Tên File ảnh" />
                        <asp:BoundField DataField="MaLoai" HeaderText="Mã loại" />
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

