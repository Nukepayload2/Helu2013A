using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBoxCity
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LstChinese.Items.AddRange((from d in Cities.Keys select new ListItem(d)).ToArray());
            }
        }
        private IDictionary<string, string> Cities = new Dictionary<string, string>()
        {
            {"北京","bejing" },{ "天津","tianjin"},{ "上海","shanghai"},{ "重庆","chongqing"}
        };
        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LstChinese.SelectedIndex >= 0)
            {
                LstEnglish.Items.Add(Cities[LstChinese.SelectedItem.Value]);
            }
        }
    }
}