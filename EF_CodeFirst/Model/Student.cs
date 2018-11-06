using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Hobby { get; set; }
    }
}
