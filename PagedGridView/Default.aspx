<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PagedGridView.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GrdNorthWindCategories" runat="server" AllowPaging="true" PageSize="3" OnPageIndexChanging="GrdNorthWindCategories_PageIndexChanging"></asp:GridView>
        </div>
    </form>
</body>
</html>
