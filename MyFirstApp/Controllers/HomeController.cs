using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View("OurProducts");
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult GetEmpName(int EmpId)
        {
            var employees = new[] {
                new {EmpId = 1, EmpName = "Ram", Salary = 5000},
                new {EmpId = 2, EmpName = "Sham", Salary = 4000},
                new {EmpId = 3, EmpName = "John", Salary = 7000},
                new {EmpId = 4, EmpName = "Mary", Salary = 3000}
            };
            string myempname = null;
            foreach(var item in employees)
            {
                if (item.EmpId == EmpId)
                    myempname = item.EmpName;
            }

            return Content(myempname, "text/plain");
        }
        public ActionResult GetPaySlip(int EmpId)
        {
            string fileName = "~/Assets/Payslip" + EmpId + ".pdf";
            return File(fileName, "application/pdf");
        }
        public ActionResult GetEmpFacebook(int EmpId)
        {
            var employees = new[] {
                new {EmpId = 1, EmpName = "Ram", Salary = 5000},
                new {EmpId = 2, EmpName = "Sham", Salary = 4000},
                new {EmpId = 3, EmpName = "John", Salary = 7000},
                new {EmpId = 4, EmpName = "Mary", Salary = 3000}
            };
            string fbUrl = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                    fbUrl = "http://facebook.com/emp" + EmpId;
            }
            if(fbUrl == null)
            {
                return Content("Invalid Employee Id");
            }
            else
            {
                return Redirect(fbUrl);
            }
        }
    }
}