<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TableLayout.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="3">网站标题</td>
                </tr>
                <tr>
                    <td rowspan="2">导航栏</td>
                    <td>内容1</td>
                    <td>内容2</td>
                </tr>
                <tr>
                    <td>内容3</td>
                    <td>内容4</td>
                </tr>
                <tr>
                    <td colspan="3">网站页脚</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
