using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVCApp.Models
{
    public class ScoreDTO
    {
        public int ChineseFraction { get; set; }

        public DateTime CreateTime { get; set; }

        public StudentDTO Student { get; set; }

        public class StudentDTO
        {
            public string Name { get; set; }
        }

    }
}