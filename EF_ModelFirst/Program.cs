using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventureWorksContextContainer OrderDB = new AdventureWorksContextContainer();

            var theOrders = OrderDB.Order.OrderBy(m=>m.Id);
            foreach (var item in theOrders)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Customer);
                Console.WriteLine(item.OrderDate);
            }
            Console.ReadLine();
        }
    }
}
