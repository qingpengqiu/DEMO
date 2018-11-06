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


                    //var Grades = from grade in orderDBContext.Grades
                    //             select grade;

                    //foreach (var item in Grades)
                    //{
                    //    Console.WriteLine("GradeId:{0};GradeName:{1}", item.Id, item.GradeName);
                    //}

                    var Students = from student in orderDBContext.Student
                                   select student;
                    foreach (var item in Students)
                    {
                        Console.WriteLine("Id:{0};StudentName:{1};Age:{2};Hobby:{3}", item.Id, item.Name, item.Age, item.Hobby);
                    }
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
