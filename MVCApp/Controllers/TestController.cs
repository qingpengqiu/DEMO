using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class TestController : Controller
    {

        public string GetString()
        {
            return SimpleMethod();
        }
        //
        [NonAction]
        public string SimpleMethod()
        {
            return "I am not a Action Method";
        }
        // GET: Test
        public ActionResult Index()
        {
            Employee employee = new Employee();
            employee.FirstName = "Michel";
            employee.SecondName = "Jorden";
            employee.Salary = 1000000;
            ViewData["employee"] = employee;
            ViewBag.employee = employee;


            return View("MyView");
        }
        /// <summary>
        /// 返回字符串类型，纯文本
        /// </summary>
        /// <returns></returns>
        public ContentResult GetContent()
        {
            ContentResult content = new ContentResult();
            content.Content = "12312";

            return content;
        }
    }
}