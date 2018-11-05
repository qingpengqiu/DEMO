using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EF_CodeFirst.Model;

namespace EF_CodeFirst
{
    class OrderContext : DbContext
    {
        public OrderContext(string connectionstring) : base(connectionstring)
        { }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
