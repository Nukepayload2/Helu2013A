using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboBoxProvinceCity
{
    public partial class Default : System.Web.UI.Page
    {
        static Dictionary<string, string[]> cities = new Dictionary<string, string[]>()
        {
            { "陕西",new string[] {"西安", "铜川", "商洛" } },
            { "河南",new string[] {"许昌", "郑州" } }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LstProvince.Items.AddRange((from k in cities.Keys select new ListItem(k)).ToArray());
                LstCity.Items.AddRange((from v in cities["陕西"] select new ListItem(v)).ToArray());
            }
        }

        protected void LstProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstCity.Items.Clear();
            if (!string.IsNullOrEmpty(LstProvince.SelectedValue))
            {
                LstCity.Items.AddRange((from v in cities[LstProvince.SelectedValue] select new ListItem(v)).ToArray());
            }
        }
    }
}