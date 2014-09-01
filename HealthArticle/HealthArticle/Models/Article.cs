using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthArticle.Models
{
    public class Article
    {
        public int  Id  { get; set; }

        [Required]
        [DisplayName("Disease Title")]
        public string  Title { get; set; }
        [Required]
        [DisplayName("Disease Description")]
        public string  Content { get; set; }

        [DisplayName("Image")]
        public string ImageId { get; set; }

    }
}