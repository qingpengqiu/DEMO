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
            string temp = "[Key=申请记录ID,Value=50,ApproveResult=False][Key=申请人ITCode,Value=KONGHAN,ApproveResult=False][Key=申请人姓名,Value=孔晗,ApproveResult=False][Key=申请人邮箱,Value=KONGHAN@digitalchina.com,ApproveResult=False][Key=申请备注,Value=采购订单修改业务，需求跟踪号：2321321321，订单号：4501230579，订单金额5500.00,ApproveResult=False][Key=URL前缀,Value=http://10.0.1.85/,ApproveResult=False][Key=事业部审批人,Value={ITCode=fansya;Name=范诗雨;Email=;TaskGroup=},ApproveResult=False][Key=事业部审批,Value=需要事业部审批,ApproveResult=True][Key=采购经理审批,Value=不需要采购经理审批,ApproveResult=True][Key=采购员改单,Value=需要采购员改单,ApproveResult=True][Key=库房冲红人,Value=,ApproveResult=False][Key=库房冲红,Value=不需要库房冲红,ApproveResult=True][Key=采购员删单,Value=不需要采购员删单,ApproveResult=True][Key=审批结果,Value=通过,ApproveResult=True]";

            temp.Split(new char[] { '[', ']' });

            temp.IndexOf("需要事业部审批");




            return "I am not a Action Method";
        }
        /// <summary>
        /// 非actions
        /// </summary>
        [NonAction]
        public void TestFun()
        {
            string OriginalCurrencyCode = "RMB";
            string CurrencyCode = "RMB";

            string OriginalTaxFileNumber = "001";
            string TaxFileNumber = "001";

            string OriginalVendorNo = "1";
            string VendorNo = "1";

            decimal OriginalOrderAmount = 100;
            decimal OrderAmount = 100;

            string OriginalFactoryCode = "8";
            string FactoryCode = "8";

            string OriginalSumNo = "9";
            string SumNo = "10";

            int IsChangeMaterial = 1;
            int Is2ERP = 1;

            if (OriginalCurrencyCode != CurrencyCode || OriginalTaxFileNumber != TaxFileNumber || OriginalVendorNo != VendorNo || OriginalOrderAmount < OrderAmount || (OriginalCurrencyCode == CurrencyCode && OriginalTaxFileNumber == TaxFileNumber && OriginalVendorNo == VendorNo && OriginalOrderAmount >= OrderAmount && Is2ERP == 1 && (OriginalFactoryCode != FactoryCode || OriginalSumNo != SumNo || IsChangeMaterial == 1)))
            {

            }





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