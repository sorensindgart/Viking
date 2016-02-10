<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="admin_Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="textCenter"><h2>Delete Subject</h2></div>
    <div class="textCenter"><asp:Literal ID="litResult" runat="server" /></div>

    <div class="textCenter"><h4>Which subject do you want to delete?</h4></div>
    <div class="textCenter"><asp:Literal ID="litSubject" runat="server" /></div>

</asp:Content>

