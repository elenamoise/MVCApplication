using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApplication.DAL
{
    public class UniversityContext:DbContext
    {
        public DbSet<University> Universities { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}