<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FormsValidation.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            用户注册信息<br />
            <br />
            用户名<asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="TxtUserName" ErrorMessage="必须填写" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            密码<asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
            重复密码<asp:TextBox ID="TxtRepeatPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator runat="server" ControlToCompare="TxtPassword" ControlToValidate="TxtRepeatPassword" ErrorMessage="两次密码不匹配" ForeColor="Red"></asp:CompareValidator>
            <br />
            年龄<asp:TextBox ID="TxtAge" runat="server"></asp:TextBox>
            <asp:RangeValidator runat="server" ControlToValidate="TxtAge" ErrorMessage="年龄必须在10~60之间" ForeColor="Red" MaximumValue="60" MinimumValue="10"></asp:RangeValidator>
            <br />
            电子邮件<asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator runat="server" ControlToValidate="TxtEmail" ErrorMessage="必须输入合法的电子邮件地址" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="BtnSubmit" runat="server" Text="提交" />

        </div>
    </form>
</body>
</html>
