using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApp.Models
{
    public class Score
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        public int ChineseFraction { get; set; }

        public int MathematicsFraction { get; set; }

        public int EnglishFraction { get; set; }

        public DateTime CreateTime { get; set; }

        public string TeacherComment { get; set; }

        public string ScoreType { get; set; }

    }
}