<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 32px;
        }
        .style3
        {
        }
        .style4
        {
            height: 24px;
        }
    </style>
</head>
<body style="background-image:url(Images/sachcf.jpg)">

    <form id="form1" runat="server">
    <div>
    
        <table cellspacing="3" class="style1" 
            style="padding-right: 400px; padding-left: 400px" width="100%">
            <tr>
                <td align="center" class="style2" colspan="2" 
                    style="background-color: #9999FF; font-weight: bold;">
                    ĐĂNG NHẬP TRANG QUẢN TRỊ&nbsp;</td>
            </tr>
            <tr>
                <td class="style4" colspan="2" style="background-color: #9999FF">
                    <strong>Vui lòng nhập tên tài khoản và mật khẩu bên dưới!</strong></td>
            </tr>
            <tr>
                <td class="style3" style="background-color: #808080">
                    Tên đăng nhập:</td>
                <td style="background-color: #808080">
                    <asp:TextBox ID="txtTenDangNhap" runat="server" Width="236px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtTenDangNhap" ErrorMessage="Chưa nhập tên đăng nhập!">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3" style="background-color: #808080">
                    Mật khẩu:</td>
                <td style="background-color: #808080">
                    <asp:TextBox ID="txtMatKhau" runat="server" Width="230px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtMatKhau" ErrorMessage="Chưa nhập mật khẩu!">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3" style="background-color: #808080">
                    &nbsp;</td>
                <td style="background-color: #808080">
                    <asp:Button ID="btlDangNhap" runat="server" onclick="btlDangNhap_Click" 
                        Text="Đăng nhập" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
            <tr>
                <td class="style3" colspan="2" style="background-color: #808080">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style3" colspan="2" style="background-color: #808080">
                    <asp:Label ID="lblLoiDangNhap" runat="server" ForeColor="#808080"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
