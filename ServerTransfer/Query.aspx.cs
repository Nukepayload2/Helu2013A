using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerTransfer
{
    public partial class Query : System.Web.UI.Page
    {
        public int Age { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Age = 123;
            Server.Transfer("Result.aspx");
        }
    }
}