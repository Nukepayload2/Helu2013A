<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ComboBoxProvinceCity.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="LstProvince" AutoPostBack="true" runat="server" OnSelectedIndexChanged="LstProvince_SelectedIndexChanged"></asp:DropDownList>
            <asp:DropDownList ID="LstCity" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
