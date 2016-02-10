<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="admin_Create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="textCenter"><h2>Add Subject</h2></div>
        <div class="textCenter"><p>Title</p></div>
        <asp:TextBox ID="txtTitle" runat="server" Autofocus placeholder="Title" CssClass="txtBox" />
    <br />
    <div class="textCenter"><p>Text</p></div>
    <asp:TextBox ID="txtText" runat="server" TextMode="MultiLine" placeholder="Text" CssClass="txtBoxMulti" />
    <br />
    <asp:FileUpload ID="fuImage" runat="server" CssClass="btnDefault" />
    <br />
    <asp:Button ID="btnSend" runat="server" Text="Add" OnClick="btnSend_Click" CssClass="btnDefault" />
    <br />
    <div class="textCenter"><asp:Literal ID="litResult" runat="server" /></div>

</asp:Content>

