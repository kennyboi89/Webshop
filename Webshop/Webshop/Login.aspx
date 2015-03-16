<%@ Page Title="Login" Language="C#" MasterPageFile="~/Webshop.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Webshop.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
      <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
    <div>
    
        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
    
    </div>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="Create User" />
        <p>
            <asp:Label ID="lbl1" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="lbl2" runat="server" Text=""></asp:Label>
        </p>

        </div>
</asp:Content>

