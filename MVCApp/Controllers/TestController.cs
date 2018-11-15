using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using MVCApp.ViewModels;

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
            employee.Salary = 10000;
            //传递到ViewData中的值，在View中可以用ViewBag获取，反之亦然
            EmployeeViewModel VMEmployee = new EmployeeViewModel();
            VMEmployee.EmployeeName = employee.FirstName + employee.SecondName;
            VMEmployee.Salary = employee.Salary;
            if (employee.Salary>15000)
            {
                VMEmployee.SalaryColor = "yellow";
            }
            else
            {
                VMEmployee.SalaryColor = "green";
            }
            VMEmployee.UserName = "Admin";
            ViewData["employee"] = employee;
            ViewBag.employee = employee;


            return View("MyView", VMEmployee);
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