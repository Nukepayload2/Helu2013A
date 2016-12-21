using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PagedGridView.Models
{
    public class Categories
    {
        [Key()]
        public int CategoryId { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
    }
}