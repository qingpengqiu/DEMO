using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CodeFirst.Model;

namespace EF_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var orderDBContext = new OrderContext("CodeFirstDb"))
            {
                var order = new Order();
                order.OrderDate = DateTime.Now;
                order.Customer = "qiuqp";
                orderDBContext.Orders.Add(order);
                orderDBContext.SaveChanges();


                var Orders = from theorder in orderDBContext.Orders
                             select theorder;
                foreach (var item in Orders)
                {
                    Console.WriteLine("OrderId:{0};OrderDate:{1}", item.Id, item.OrderDate);
                }
                Console.ReadLine();
              
            }
        }
    }
}
