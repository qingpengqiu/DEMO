using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using AutoMapper.QueryableExtensions;
using System.Runtime.CompilerServices;
using AutoMapper;
using System.Reflection;
using System.Data.Entity.Core.Objects;
using System.Linq.Expressions;

namespace MvcApplication3.Controllers
{
    public class ScoresDto
    {
        public int ChineseFraction { get; set; }
        public DateTime CreateTime { get; set; }

        public StudentDto Student { get; set; }

        public class StudentDto
        {
            public string Name { get; set; }
        }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DB db = new DB();

            //var scores = db.Scores
            //   .Take(100)             
            //   .ToList();
            //foreach (var item in scores)
            //{
            //    var teacherName = item.Student.Name;
            //} 

            //var scores = db.Scores
            //    .Take(100)
            //    .Include(t => t.Student)
            //    .Select(t => new { t.ChineseFraction, t.CreateTime, StudentName = t.Student.Name })
            //    .ToList();
            //foreach (var item in scores)
            //{
            //    var teacherName = item.StudentName;
            //}

            ////此处CreateMap应该放入Global.asax里面执行
            //Mapper.CreateMap<Score, ScoresDto>();
            //Mapper.CreateMap<Student, ScoresDto.StudentDto>();

            //var scores = db.Scores
            //    .Take(100)          
            //    .ProjectTo<ScoresDto>()
            //    .ToList();
            //foreach (var item in scores)
            //{
            //    var teacherName = item.Student.Name;
            //}

            //List<object> list = new List<object>();
            //var students = db.Students.Take(100).ToList();
            //foreach (var student in students)
            //{
            //    if (student.Scores != null)
            //    {
            //        var count = student.Scores
            //            .GroupBy(t => t.ScoreTyep)
            //            .Select(t => new
            //            {
            //                Count = t.Count(),
            //                chineseAvg = t.Average(e => e.ChineseFraction),
            //                ScoreTyep = t.Key,
            //                student.Name
            //            })
            //            .Where(t => t.Count >= 3)
            //            .ToList();
            //    }
            //}

            //List<object> list = new List<object>();
            //var students = db.Students.Take(100).Include(t=>t.Scores).ToList();
            //foreach (var student in students)
            //{
            //    if (student.Scores != null)
            //    {
            //        var count = student.Scores
            //            .GroupBy(t => t.ScoreTyep)
            //            .Select(t => new
            //            {
            //                Count = t.Count(),
            //                chineseAvg = t.Average(e => e.ChineseFraction),
            //                ScoreTyep = t.Key,
            //                student.Name
            //            })
            //            .Where(t => t.Count >= 3)
            //            .ToList();
            //    }
            //}

            //var students = db.Students
            //    .Take(100)
            //    .SelectMany(t => t.Scores.Select(e => new { e.ScoreTyep, e.ChineseFraction, t.Name }))
            //    .GroupBy(t => t.ScoreTyep)
            //    .Select(t => new
            //    {
            //        Count = t.Count(),
            //        ChineseAvg = t.Average(e => e.ChineseFraction),
            //        ScoreTyep = t.Key,
            //        StudentName = t.Max(e => e.Name)
            //    })
            //    .Where(t => t.Count >= 3)
            //    .ToList(); 


            //var studentNames = db.Students.Where(t => t.Name == "张三").ToList(); 
            //var studentNames2 = db.Students.Where(t => t.Name == DbFunctions.AsNonUnicode("张三")).ToList();


            //var studentNames = db.Students.Where(t => t.Name.Contains("张三")).AsNoTracking().ToList(); 
            //var studentNames2 = db.Students.Where(t => t.Name.Contains("张三")).ToList();

            //var studentNames = db.Students
            //    .Where(t => t.Name.Contains("张三"))
            //    .OrderBy(t => new { t.Name, t.Age })
            //    .ThenByDescending(t=>t.Age)
            //    .AsNoTracking()
            //    .ToList();

            //var str = "name desc";//前端传过来的数据
            //var studentIQuery = db.Students
            // .AsNoTracking()
            // .Where(t => t.Name.Contains("张三"));
            //switch (str)
            //{
            //    case "name asc":
            //        studentIQuery = studentIQuery.OrderBy(t => t.Name);
            //        break;
            //    case "name desc":
            //        studentIQuery = studentIQuery.OrderByDescending(t => t.Name);
            //        break;
            //    case "age asc":
            //        studentIQuery = studentIQuery.OrderBy(t => t.Age);
            //        break;
            //    case "age desc":
            //        studentIQuery = studentIQuery.OrderByDescending(t => t.Age);
            //        break;
            //    case "name asc,age desc":
            //        studentIQuery = studentIQuery.OrderBy(t => t.Name).ThenByDescending(t => t.Age);
            //        break;

            //    // 各种 case 可能 、、、、有没有崩溃？？？？
            //}
            //var studentNames = studentIQuery.ToList();


            //var studentNames = db.Students
            //    .AsNoTracking()
            //    .Where(t => t.Name.Contains("张三"))
            //    .OrderBy("name asc,age desc")
            //    .ToList();


            //var type = "2";//根据不同情况查询，可能情况

            //var studentIQuery = db.Students
            //   .AsNoTracking()
            //   .Where(t => true);
            //switch (type)
            //{
            //    case "1":
            //        studentIQuery = studentIQuery.Where(t => t.Name == "张三");
            //        break;
            //    case "2":
            //        studentIQuery = studentIQuery.Where(t => (t.Name == "张三" || t.Age == "18"));
            //        break;
            //}
            //var students = studentIQuery.ToList();


            //var type = "2";
            ////条件拼接
            //Expression<Func<Student, bool>> expression = t => t.Name == "张三";
            //if (type == "2")
            //    expression = expression.Or(t => t.Age == "18");

            //var students = db.Students
            //   .AsNoTracking()
            //   .Where(expression)//代入上面拼接的条件
            //   .ToList();


            //var aa = db.Students.Where(t => t.Name == "张三2").Count() > 0; 

            //var bb = db.Students.Where(t => t.Name == "张三2").FirstOrDefault() != null;

            //var zz = db.Students.Any(t => t.Name == "张三2");

            ////学生姓名
            //List<string> studenNames = new List<string>() { "张三3", "李四" };
            ////第一种方式
            //var dd = db.Teachers
            //    .Where(t => t.Students.Where(s => studenNames.Contains(s.Name)).FirstOrDefault() != null)
            //    .Select(t => t.Name)
            //    .ToList();
            ////第二种方式
            //dd = db.Teachers
            //    .Where(t => t.Students.Any(s => studenNames.Contains(s.Name)))
            //    .Select(t => t.Name)
            //    .ToList();


            ////学生姓名
            //List<string> studenNames = new List<string>() { "张三3", "李四" };
            ////第一种方式
            //var dd = db.Teachers
            //    .Where(t => t.Students.Any(s => studenNames.Contains(s.Name)))
            //    .Select(t => t.Name)
            //    .ToList();
            ////第二种方式
            //dd = db.Teachers
            //   .Where(t => t.Students.Where(s => studenNames.Contains(s.Name)).Count() > 0)
            //   .Select(t => t.Name)
            //   .ToList(); 
            ////第三种方式
            //dd = db.Teachers
            //  .Where(t => t.Students.Where(s => studenNames.Contains(s.Name)).FirstOrDefault() != null)
            //  .Select(t => t.Name)
            //  .ToList();

            ////学生姓名
            //List<string> studenNames = new List<string>() { "张三3", "李四" };
            ////
            //var dd = db.Teachers
            //  .Where(t => t.Students.Where(s => studenNames.Contains(s.Name)).FirstOrDefault() != null
            //      && t.Students.Where(s => studenNames.Contains(s.Name)).FirstOrDefault().Name.Contains("张三")
            //      && t.Students.Where(s => studenNames.Contains(s.Name)).FirstOrDefault().Age == "18")
            //  .Select(t => t.Students.Where(s => studenNames.Contains(s.Name)).FirstOrDefault().Name)
            //  .ToList();

            //dd = db.Teachers
            //  .Select(t => new { Students = t.Students.Where(s => studenNames.Contains(s.Name)).FirstOrDefault() })
            //  .Where(t => t.Students != null
            //      && t.Students.Name.Contains("张三")
            //      && t.Students.Age == "18")
            //  .Select(t => t.Students.Name)
            //  .ToList();

            Mapper.CreateMap<Score, ScoresDto>();
            Mapper.CreateMap<Student, ScoresDto.StudentDto>();
            var age = "";
            //1、WhereIf
            db.Students.WhereIf(!string.IsNullOrEmpty(age), t => t.Age == age).ToList();
            //2、PageBy(分页)
            db.Students.OrderBy(t=>t.Name).PageBy(10, 15).ToList();
            //3、Select（直接映射DTO）
            db.Scores.Where(t => true).Select<ScoresDto>().ToList();
            //4、OrderBy（传字符串）
            db.Students.AsNoTracking().OrderBy("name asc,age desc").ToList();
            //5、And Or Lamdba拼接         
            Expression<Func<Student, bool>> expression = t => t.Name == "张三";
            expression = expression.Or(t => t.Age == "18");
            expression = expression.And(t => t.Teachers.Count() > 2);
            db.Students.Where(expression).ToList();

            return View();
        } 

        #region AddData
        public ActionResult AddData()
        {
            DB db = new DB();

            List<Teacher> teachers = new List<Teacher>();
            for (int i = 0; i < 1000; i++)
            {
                teachers.Add(new Teacher()
                {
                    Age = i.ToString(),
                    Name = "Teacher" + i.ToString()
                });
            }
            db.Teachers.AddRange(teachers);
            db.SaveChanges();


            var teas = db.Teachers.ToList();
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    var r = new Random(j);
                    var stu = new Student()
                               {
                                   //Id = 1,
                                   Age = (j + i).ToString(),
                                   Name = "张三" + j.ToString(),
                                   Teachers = new List<Teacher>() { 
                                   teas[r.Next(teas.Count())],
                                   teas[r.Next(teas.Count())],
                                   teas[r.Next(teas.Count())] 
                                   }
                               };
                    students.Add(stu);
                }
            }

            db.Students.AddRange(students);
            db.SaveChanges();

            var stus = db.Students.Select(t => t.Id).ToList();
            List<Score> scores = new List<Score>();
            if (stus.Count() > 0)
                for (int z = 0; z < 10000; z++)
                {
                    var r = new Random(z);
                    var score = new Score()
                    {
                        ChineseFraction = r.Next(100),
                        CreateTime = DateTime.Now,
                        EnglishFraction = r.Next(100),
                        MathematicsFraction = r.Next(100),
                        ScoreTyep = (Models.ScoreTyep)r.Next(0, 2),
                        TeacherComment = GetTeacherComment(r),
                        StudentId = stus[r.Next(stus.Count())]
                    };
                    scores.Add(score);
                }
            db.Scores.AddRange(scores);
            db.SaveChanges();


            return View();
        }

        public string GetTeacherComment(Random r)
        {
            var strkey = new string[] { "张三", "李四", "王五", "郑六" };
            //var str = string.Empty;
            //str = @"我们很多人都有过写点东西的冲动，只是又因为种种原因没有发表。";
            //str += strkey[r.Next(strkey.Length)];
            //for (int i = 0; i < 10; i++)
            //{
            //    str += str[r.Next(str.Length)];
            //}
            return strkey[r.Next(strkey.Length)];
        }

        #endregion
    }
}
