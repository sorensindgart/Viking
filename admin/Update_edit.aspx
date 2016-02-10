<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="Update_edit.aspx.cs" Inherits="admin_Update_edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="textCenter"><h2>Edit Subject</h2></div>

    <div class="textCenter"><p>Title</p></div>
    <asp:TextBox ID="txtTitle" runat="server" autofocus CssClass="txtBox" />
    <br />
    <div class="textCenter"><p>Text</p></div>
    <asp:TextBox ID="txtText" runat="server" TextMode="MultiLine" CssClass="txtBoxMulti" />
    <br />
    <asp:Image ID="imgImage" runat="server" CssClass="textCenter" />
    <br />
    <asp:CheckBox ID="chbImg" runat="server" Text="Delete image" CssClass="textCenter" />
    <br />
    <asp:FileUpload ID="fuImage" runat="server" CssClass="textCenter" />
    <br />
    <asp:Button ID="btnSend" runat="server" Text="Edit" OnClick="btnSend_Click" CssClass="btnDefault" />
    <br />
    <asp:Literal ID="litResult" runat="server" />
</asp:Content>

