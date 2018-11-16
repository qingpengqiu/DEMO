using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using MVCApp.ViewModels;
using MVCApp.BLL;

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
        public ActionResult MyView()
        {
            //传递到ViewData中的值，在View中可以用ViewBag获取，反之亦然
            IList<Employee> Employees = new EmployeeBusinessLayer().GetEmployees();
            IList<EmployeeViewModel> EmployeeViewModels = new List<EmployeeViewModel>();
            foreach (var employee in Employees)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.EmployeeName = employee.FirstName + employee.SecondName;
                employeeViewModel.Salary = employee.Salary;
                if (employee.Salary > 15000)
                {
                    employeeViewModel.SalaryColor = "yellow";
                }
                else
                {
                    employeeViewModel.SalaryColor = "green";
                }
                EmployeeViewModels.Add(employeeViewModel);
            }
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            employeeListViewModel.Employees = EmployeeViewModels;
            employeeListViewModel.UserName = "Admin";

            

            return View("MyView", employeeListViewModel);
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