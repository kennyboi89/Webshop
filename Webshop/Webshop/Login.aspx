<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Webshop.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
    <div>
    
        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
    
    </div>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        <p>
            <asp:Label ID="lbl1" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="lbl2" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
