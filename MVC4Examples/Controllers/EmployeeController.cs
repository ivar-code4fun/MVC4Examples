using MVC4Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4Examples.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.ToList();

            return View(employees);
        }

        public ActionResult Details(int id)
        {
            //Employee employee = new Employee() { EmployeeId = 100, Name = "John", Gender = "Male", City = "Seattle" };

            //return View(employee);

            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(e => e.EmployeeId == id);

            return View(employee);
        }

    }
}
