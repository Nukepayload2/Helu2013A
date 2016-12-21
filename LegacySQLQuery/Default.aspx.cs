using LegacySQLQuery.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LegacySQLQuery
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 用于添加示例数据。考试不写。
                using (var db = new Product())
                {
                    if (!db.Products.Any())
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            db.Products.Add(new ProductSet() { Stock = i * 10 + 213, Price = i * 200, ProductName = "示例产品" + i });
                        }
                    }
                    db.SaveChanges();
                }
            }
        }

        protected void BtnQuery_Click(object sender, EventArgs e)
        {
            // 传统的查询代码
            var connStr = WebConfigurationManager.ConnectionStrings["Product"].ConnectionString;

            using (var conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM [Product] WHERE @QueryProductName = ProductName";
                        cmd.Parameters.Add("QueryProductName", SqlDbType.VarChar, 50).Value = TxtProductName.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Response.Write($"价格：{reader.GetDecimal(2)}, 存货 {reader.GetInt32(3)}<br/>");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}