<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GridViewGoToDetail.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GrdData" runat="server" OnRowCommand="GrdData_RowCommand">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CommandName="Detail" ID="BtnView" runat="server" Text="查看" OnClientClick="return confirm('是否要查看该条记录？');"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
