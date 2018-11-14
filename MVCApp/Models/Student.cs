using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string Hobby { get; set; }

        public virtual ICollection<Teacher> Teachers {get;set;}

        [ForeignKey("StudentId")]
        public ICollection<Score> Scores { get; set; }
    }
}