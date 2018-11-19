using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApp.DAL;
using MVCApp.Models;
using MVCApp.ViewModels;

namespace MVCApp.BLL
{
    public class EmployeeBusinessLayer
    {
        SchoolDB schoolDB = new SchoolDB();
        /// <summary>
        /// Employee Model List
        /// </summary>
        /// <returns></returns>
        public IList<Employee> GetEmployees()
        {
            return schoolDB.Employees.ToList();
        }
        /// <summary>
        /// 返回EmployeeListViewModel
        /// </summary>
        /// <returns></returns>
        public IList<EmployeeViewModel> GetEmployeeListViewModel()
        {
            IList<Employee> Employees = schoolDB.Employees.ToList();

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

            return EmployeeViewModels;
        }


        //保存数据
        public Employee SaveEmployee(Employee employee)
        {
            schoolDB.Employees.Add(employee);
            schoolDB.SaveChanges();

            return employee;
        }
    }
}