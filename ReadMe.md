# 互联网程序设计突击复习题
## 目录
<table>
    <thead>
        <tr>
            <td><strong>项目描述</strong></td>
            <td><strong>项目名称</strong></td>
        </tr>
    </thead>
    <tr>
        <td><strong>Helu2013A</strong></td>
        <td><p>此复习题项目的介绍</p></td>
    </tr>
    <tr>
        <td><strong>PagedGridView</strong></td>
        <td><p>分页显示NorthWind.mdb数据库中Categories表的内容，每页显示3个记录，并且能够通过点击数据网格下部的分页号码显示不同的页面记录。注意：数据采用程序查询填充而不是数据源控件。</p></td>
    </tr>
    <tr>
        <td><strong>ListBoxCity</strong></td>
        <td><p>选择左边列表框时，在页面底部显示所选择的城市名；此时，点击“>>”按钮，则把该城市的英文名添加到右边的列表框中。北京，上海，天津，重庆。</p></td>
    </tr>
    <tr>
        <td><strong>OnlinePersonCount</strong></td>
        <td>请写出在线人数统计的关键代码</td>
    </tr>
    <tr>
        <td><strong>CookiesAuth</strong></td>
        <td>请利用cookie编写用户登录程序</td>
    </tr>
    <tr>
        <td><strong>TableLayout</strong></td>
        <td>请利用HTML设计 页眉-内容(左侧导航栏，四个内容栏)-页脚 的表格页面</td>
    </tr>
    <tr>
        <td><strong>LegacySQLQuery</strong></td>
        <td><p>在SQLEXPRESS数据库中有一张Product表，表结构: <br />
                    CREATE TABLE [dbo].[Product] (<br/>
                    &nbsp;&nbsp;&nbsp;&nbsp;[ProductId]   INT             IDENTITY (1, 1) NOT NULL,<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;[ProductName] VARCHAR (50)    NOT NULL,<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;[Price]       DECIMAL         NOT NULL,<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;[Stock]       INT             NOT NULL,<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;CONSTRAINT [PK_dbo.Product] PRIMARY KEY CLUSTERED ([ProductId] ASC)<br />
                    );<br />
                请采用面向连接的方式编写代码，提供按ProductName查询的功能。（只写出程序，不用写出页面设计）</p></td>
    </tr>
    <tr>
        <td><strong>GridViewGoToDetail</strong></td>
        <td>在GridView控件中，放置一个模板列，其中放置一个“查看”按钮，当用户点击按钮时提示“是否要查看该条记录？”，如果用户选择“是”则跳转，否则不向服务器提交页面。请编写关键的C#和javascript代码。</td>
    </tr>
    <tr>
        <td><strong>ComboBoxProvinceCity</strong></td>
        <td>在页面上放置“省份”下拉列表框和“城市”下拉列表框，要求根据选择的省份动态填充“城市”下拉列表框。</td>
    </tr>
    <tr>
        <td><strong>ServerTransfer</strong></td>
        <td>编程使用强类型的方法从query.aspx页面向result.aspx页面传递一个int类型的变量age</td>
    </tr>
    <tr>
        <td><strong>FormsValidation</strong></td>
        <td>设计用户注册Web页面，在点击“提交”按钮时，对各个文本框输入的内容进行验证，有约束条件和错误提示。内容包括：用户名必须填写，密码，重复密码，密码匹配，年龄，范围10到60，电子邮件，必须是合法的电子邮件地址。</td>
    </tr>
</table>