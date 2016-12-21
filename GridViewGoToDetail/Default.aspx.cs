using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewGoToDetail
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GrdData.DataSource = Enumerable.Repeat<object>(new { dummy = "dummy" }, 10).ToArray();
                DataBind();
            }
        }

        protected void GrdData_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detail")
            {
                Response.Redirect("Detail.aspx");
            }
        }
    }
}