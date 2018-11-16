using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.ViewModels
{
    public class EmployeeListViewModel
    {
        public IList<EmployeeViewModel> Employees { get; set; }

        public string UserName { get; set; }
    }
}