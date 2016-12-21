using PagedGridView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PagedGridView
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var db = new NorthWind())
                {
                    // 插入示例数据。考试不写这个。
                    if (!db.Categories.Any())
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            db.Categories.Add(new Categories() { CategoryName = "呵呵哒" + i, Description = "我是示例数据" + i });
                        }
                        db.SaveChanges();
                    }
                    // 查询和绑定数据
                    GrdNorthWindCategories.DataSource = db.Categories.ToArray();
                    GrdNorthWindCategories.DataBind();
                }
            }
        }

        protected void GrdNorthWindCategories_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            using (var db = new NorthWind())
            {
                GrdNorthWindCategories.PageIndex = e.NewPageIndex;
                // 重新绑定数据
                GrdNorthWindCategories.DataSource = db.Categories.ToArray();
                GrdNorthWindCategories.DataBind();
            }
        }
    }
}