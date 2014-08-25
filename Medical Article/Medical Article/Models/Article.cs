using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medical_Article.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
             
        [Display(Name = "Heading of The Article")]
        public string Headings { get; set; }
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        public string Image { get; set; }            
    }
}