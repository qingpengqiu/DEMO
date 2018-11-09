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
            try
            {
                using (var orderDBContext = new OrderContext())
                {
                    //var order = new Order();
                    //order.OrderDate = DateTime.Now;
                    //order.Customer = "qiuqp";
                    //orderDBContext.Orders.Add(order);
                    //orderDBContext.SaveChanges();


                    //var grades = from grade in orderDBContext.Grades
                    //             select grade;

                    //foreach (var item in grades)
                    //{
                    //    Console.WriteLine("gradeid:{0};gradename:{1}", item.Id, item.GradeName);
                    //}

                    var Students = from student in orderDBContext.Students
                                   select student;

                    foreach (var item in Students)
                    {
                        Console.WriteLine("Id:{0};StudentName:{1};Age:{2};Hobby:{3}", item.Id, item.Name, item.Age, item.Hobby);
                    }

                    //var DataList = from O in orderDBContext.Orders
                    //               join D in orderDBContext.OrderDetails on O.Id equals D.OrderId
                    //               into Order_Details
                    //               from D in Order_Details
                    //               where O.Id > 0
                    //               select new OrderDetailView
                    //               {
                    //                   Customer = O.Customer,
                    //                   Product = D.Product
                    //               };

                    //foreach (var item in DataList)
                    //{
                    //    Console.WriteLine("客户：{0}；产品：{1}", item.Customer, item.Product);
                    //}

                    Console.ReadLine();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
        }
    }
}
