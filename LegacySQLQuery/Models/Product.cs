namespace LegacySQLQuery.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class Product : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“Product”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“LegacySQLQuery.Models.Product”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“Product”
        //连接字符串。
        public Product()
            : base("name=Product")
        {
        }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        public virtual DbSet<ProductSet> Products { get; set; }
    }

    [Table("Product")]
    public class ProductSet
    {
        [Key()]
        public int ProductId { get; set; }
        [StringLength(50), Column(TypeName = "VARCHAR")]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}