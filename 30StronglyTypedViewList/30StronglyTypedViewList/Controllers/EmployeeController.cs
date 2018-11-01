using _30StronglyTypedViewList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _30StronglyTypedViewList.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            List<Employee> emp = new List<Employee>
            {   new Employee { EmployeeId=1, FirstName="Akshay", LastName= "Patel", Email="akshayblevel@gmail.com" }, 
                new Employee { EmployeeId=2, FirstName="Rajesh", LastName= "Patel", Email="rajkatie@gmail.com" }
            };

            ViewData.Model = emp;

            return View();
        }
	}
}