<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCC_MenuNgang.ascx.cs" Inherits="UCC_MenuNgang" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>

<table cellspacing="1" class="style1">
    <tr>
        <td align="center" style="height: 35px; background-color: #009933;" 
            width="100%">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" 
                Font-Bold="True" Font-Underline="False" ForeColor="#333399">Trang chủ</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" Font-Underline="False" 
                NavigateUrl="~/GioiThieu.aspx" style="color: #000000">Giới thiệu</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Login.aspx" 
                Font-Bold="True" Font-Underline="False" ForeColor="#333399">Đăng nhập</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp; 
            
        </td>
    </tr>
</table>

