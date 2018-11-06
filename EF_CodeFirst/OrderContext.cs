using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EF_CodeFirst.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EF_CodeFirst
{
    class OrderContext : DbContext
    {
        public OrderContext() : base("name=CodeFirstDB")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent API
            //删除S||ES映射约束
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Student> Student { get; set; }

        

    }
}
