using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesAuth
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text=="helu" && TxtPassword.Text=="123")
            {
                Response.SetCookie(new HttpCookie("User", "helu"));
                Response.Redirect("Default.aspx");
            }
        }
    }
}