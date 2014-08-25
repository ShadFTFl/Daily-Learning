using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Medical_Article.Models
{
    public class ContextDb:DbContext
    {
        public DbSet<Article> Articles { get; set; }
 
    }
}