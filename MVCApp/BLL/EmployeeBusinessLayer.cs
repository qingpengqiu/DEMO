using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApp.DAL;
using MVCApp.Models;

namespace MVCApp.BLL
{
    public class EmployeeBusinessLayer
    {
        SchoolDB schoolDB = new SchoolDB();

        public IList<Employee> GetEmployees()
        {
            return schoolDB.Employees.ToList();
        }
    }
}