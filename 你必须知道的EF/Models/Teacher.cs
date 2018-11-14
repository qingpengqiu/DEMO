using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    /// <summary>
    /// 老师
    /// </summary>
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}