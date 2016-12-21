<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LegacySQLQuery.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TxtProductName" runat="server"></asp:TextBox>
            <asp:Button ID="BtnQuery" runat="server" Text="查询" OnClick="BtnQuery_Click" />
        </div>
    </form>
</body>
</html>
