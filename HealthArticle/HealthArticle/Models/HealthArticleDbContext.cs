using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HealthArticle.Models
{
    public class HealthArticleDbContext: DbContext
    {
        public HealthArticleDbContext():base("HealthArticleConnectionString")
        {
            
        }

       public  DbSet<Article> Articles { get; set; } 
        
    }
}