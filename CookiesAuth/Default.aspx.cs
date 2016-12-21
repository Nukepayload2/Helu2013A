using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesAuth
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request.Cookies["User"]?.Value;
            if (string.IsNullOrEmpty(user))
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write($"欢迎，{user}！");
            }
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["User"].Expires = DateTime.MinValue;
            Response.Redirect("Login.aspx");
        }
    }
}