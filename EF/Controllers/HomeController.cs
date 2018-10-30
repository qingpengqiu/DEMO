using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF;


namespace EF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            SchoolContainer SchoolDb = new SchoolContainer();

            IList<Student> Students = SchoolDb.StudentSet.ToList<Student>();

            return View(Students);
        }
    }
}