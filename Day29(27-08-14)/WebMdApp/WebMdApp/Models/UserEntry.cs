using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebMdApp.Models
{
    public class UserEntry
    {
        [Key]
        public int UserId { set; get; }
        [DisplayName("Full Name")]
        public string FullName { set; get; }
        [DisplayName("User Name")]
        public string UserName { set; get; }
        [DisplayName("Email")]
        public string Email { set; get; }

        [DataType(DataType.Password)]
        public string Password { set; get; }


        [DisplayName("User Type")]
        public int UserTypeId { set; get; }
        public virtual UserType UserType { set; get; }
    }
}