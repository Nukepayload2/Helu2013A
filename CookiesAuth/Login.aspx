<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CookiesAuth.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            登录<br />
            <br />
            用户名<br />
            <asp:TextBox ID="TxtUser" runat="server"></asp:TextBox>
            <br />
            密码<br />
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="BtnLogin" runat="server" OnClick="BtnLogin_Click" Text="登录" />
        </div>
    </form>
</body>
</html>
