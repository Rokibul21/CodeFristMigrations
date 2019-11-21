using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFastMigration2.Models
{
    public class ProjectDbContext:DbContext
    {
        public DbSet<Departments> Department { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}