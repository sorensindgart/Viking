<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h2>Welcome to the admin-page</h2>
    <p>If you want to logout,</p>
    <asp:Button ID="btnLogout" runat="server" Text="Click Here" OnClick="btnLogout_Click" />
</asp:Content>

