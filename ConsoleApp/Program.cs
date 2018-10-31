using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolEntities SchoolDB = new SchoolEntities();

            var GradeModels = SchoolDB.Grades.OrderBy(m => m.Id).Select(m => new {ID = m.Id,GradeName=m.GradeName });
            if (GradeModels.Count()>0)
            {
                Console.WriteLine("ID:{0}", GradeModels.First().ID);
                Console.WriteLine("GradeName:{0}", GradeModels.First().GradeName);
                Console.ReadLine();
            }
        }
    }
}
