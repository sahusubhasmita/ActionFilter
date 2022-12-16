using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewEmployee.ActionFilter;
using NewEmployee.Models;

namespace NewEmployee.Controllers
{
    [studentFilter]
    public class EmployeeController : Controller
    {
        // GET: Employee
        //[Authorize]
        [HttpGet]
        public ActionResult Student()
        {
            return View();
        }
        //[Authorize(Roles ="Admin")]
        [HttpPost]
         public ActionResult Student(Employees employess)
        {
            return View();
        }
    }
}