<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ListBoxCity.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="LstChinese" runat="server" Height="331px" Width="226px"></asp:ListBox>
            <asp:Button ID="BtnAdd" runat="server" Text="&gt;&gt;" OnClick="BtnAdd_Click" />
            <asp:ListBox ID="LstEnglish" runat="server" Height="331px" Width="226px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
