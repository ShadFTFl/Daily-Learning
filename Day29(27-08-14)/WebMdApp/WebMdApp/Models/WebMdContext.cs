using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebMdApp.Models
{
    public class WebMdContext: DbContext
    {
        public DbSet<UserEntry> UserEntries { set; get; }
        public DbSet<UserType> UserTypes { set; get; }
        public DbSet<Doctor> Doctors { set; get; }
        public DbSet<Article> Articles { set; get; }
    }
}