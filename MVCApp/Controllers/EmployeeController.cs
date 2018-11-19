using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using MVCApp.ViewModels;
using MVCApp.DAL;
using MVCApp.BLL;

namespace MVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            employeeListViewModel.Employees = new EmployeeBusinessLayer().GetEmployeeListViewModel();
            employeeListViewModel.UserName = "Admin";

            return View("Index", employeeListViewModel);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }


        public ActionResult SaveEmployee(Employee emp)
        {
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBLL = new EmployeeBusinessLayer();
                employeeBLL.SaveEmployee(emp);

                return RedirectToAction("Index");
            }
            else
            {
                return View("CreateEmployee");
            }

        }

    }
}