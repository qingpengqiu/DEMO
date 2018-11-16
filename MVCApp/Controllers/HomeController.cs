using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutoMapper.Configuration;
using MVCApp.Models;
using MVCApp.DAL;


namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            SchoolDB schoolDB = new SchoolDB();



            #region AutoMapper应用
            //var MapperCFG = new MapperConfigurationExpression();
            //MapperCFG.CreateMap<Score, ScoreDTO>();
            //Mapper.Initialize(MapperCFG);

            //var Scores = schoolDB.Scores.Take(100).ProjectTo<ScoreDTO>().ToList();
            //foreach (var item in Scores)
            //{
            //    var studentName = item.Student.Name;
            //}

            #endregion

            #region 联表查询
            //方式一
            //var students = schoolDB.Students;
            //foreach (var student in students)
            //{
            //    if (student.Scores != null)
            //    {
            //        var count = student.Scores
            //            .GroupBy(t => t.ScoreType)
            //            .Select(t => new
            //            {
            //                Count = t.Count(),
            //                ChineseAvg = t.Average(e => e.ChineseFraction),
            //                ScoreType = t.Key,
            //                student.Name
            //            })
            //            .Where(t => t.Count >= 3)
            //            .ToList();
            //    }
            //}

            //方式二
            //var students = schoolDB.Students.Take(100).Include(t => t.Scores).ToList();
            //foreach (var student in students)
            //{
            //    if (student.Scores != null)
            //    {
            //        var count = student.Scores
            //            .GroupBy(t => t.ScoreType)
            //            .Select(t => new
            //            {
            //                Count = t.Count(),
            //                ChineseAvg = t.Average(e => e.ChineseFraction),
            //                ScoreType = t.Key,
            //                student.Name
            //            })
            //            .Where(t => t.Count >= 3)
            //            .ToList();
            //    }
            //}

            //方式三 SelectMany
            //var students = schoolDB.Students
            //    .Take(100)
            //    .SelectMany(t => t.Scores.Select(e => new { e.ScoreType, e.ChineseFraction, t.Name }))
            //    .GroupBy(t => t.ScoreType)
            //    .Select(t => new
            //    {
            //        Count = t.Count(),
            //        ChineseAVG = t.Average(c => c.ChineseFraction),
            //        ScoreType = t.Key,
            //        StudentName = t.Max(e => e.Name)
            //    })
            //    .Where(t => t.Count >= 3)
            //    .ToList();


            #endregion

            #region 性能提升
            ////AsNonUnicode,Unicode-所有字符占用两个字节存储空间
            //var studentName = schoolDB.Students.Where(t => t.Name == "张三").ToList();
            //var studentNameN = schoolDB.Students.Where(t => t.Name == DbFunctions.AsNonUnicode("张三")).ToList();
            ////AsNoTracking 无跟踪查询,仅做查询处理,查询出来的对象不能进行修改操作
            //studentName = schoolDB.Students.Where(t => t.Name.Contains("张三")).ToList();
            //studentNameN = schoolDB.Students.Where(t => t.Name.Contains("张三")).AsNoTracking().ToList();
            #endregion

            #region 多字段组合排序-ThenBy
            //var studentNames = schoolDB.Students
            //    .Where(t => t.Name.Contains("张"))
            //    .OrderBy(t => t.Name)
            //    .ThenBy(t => t.Age)
            //    .AsNoTracking()
            //    .ToList();

            //var studentNames1 = schoolDB.Students
            //                .Where(t => t.Name.Contains("张"))
            //                .OrderBy(t => new { t.Name,t.Age})
            //                .AsNoTracking()
            //                .ToList();

            //System.Linq.Dynamic下的扩展方法
            //var studentNames1 = schoolDB.Students
            //                .Where(t => t.Name.Contains("张"))
            //                .OrderBy("Name asc,Age Desc")
            //                .AsNoTracking()
            //                .ToList();

            #endregion

            //var Scores = schoolDB.Scores.Take(100).Include(t => t.Student).Select(t=>new { t.ChineseFraction,t.CreateTime,t.EnglishFraction,t.TeacherComment,t.Student.Name})
            //    .ToList();


            return View();

        }
    }

}