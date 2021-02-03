<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_TrangChu.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register src="UCC_AllSachDataList.ascx" tagname="UCC_AllSachDataList" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:UCC_AllSachDataList ID="UCC_AllSachDataList1" runat="server" />
</asp:Content>

