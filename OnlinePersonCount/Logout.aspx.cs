using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlinePersonCount
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["User"]!=null)
                {
                    Response.Write($"欢迎，{Session["User"]}！<br/> 现在在线人数：{Application["UserOnline"]}");
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}