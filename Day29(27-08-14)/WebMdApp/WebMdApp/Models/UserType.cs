using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMdApp.Models
{
    public class UserType
    {
        [Key]
        public int UserTypeId { set; get; }
        public string Type { set; get; }
        
        //public UserType
    }
}