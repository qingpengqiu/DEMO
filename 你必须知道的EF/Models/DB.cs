using MvcApplication3.Migrations;
using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication3
{
    public class DB : DbContext
    {
        public DB()
            : base("Default")
        {
            //每次重新启动总是初始化数据库到最新版本（连接字符串为“Default”）
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DB, Configuration>("Default"));
        }

        /// <summary>
        /// 学生集合
        /// </summary>
        public DbSet<Student> Students { get; set; }
        /// <summary>
        /// 老师集合
        /// </summary>
        public DbSet<Teacher> Teachers { get; set; } 
        /// <summary>
        /// 成绩集合
        /// </summary>
        public DbSet<Score> Scores { get; set; }

    }
}