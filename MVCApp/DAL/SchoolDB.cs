using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MVCApp.Models;

namespace MVCApp.DAL
{
    public class SchoolDB : DbContext
    {
        public SchoolDB() : base("name=SchoolDB")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Score> Scores { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}