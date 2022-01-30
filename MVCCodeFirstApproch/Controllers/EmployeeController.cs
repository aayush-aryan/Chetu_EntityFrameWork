using Microsoft.AspNetCore.Mvc;
using MVCCodeFirstApproch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCodeFirstApproch.Controllers
{
    public class EmployeeController : Controller
    {
        //to inject Employee View page (index.cshtml) or to inject Employee Service class in our conroller
        //for showing emplyee dynamic data in our view page
        private ApplicationDbContext dbContext; //dbContext is the property name

        public EmployeeController(ApplicationDbContext context)
        {
            dbContext = context;
        }
       // public IActionResult Index()
       // {
       //     var emps = new List<string>() { "Rahul", "Deepak", "John", "Ajay" };
        //    ViewBag.employees = emps;
        //    return View();
       // }

        public IActionResult Index()
        {
            var emps = dbContext.Employees.ToList();
            return View(emps);
        }
        // for data loading by default HttpGet method be call by this method;
        public IActionResult Create()
        {
            return View();
        }

        //for data submit Post method is used
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            //for adding data in database; (in employee model class)
            dbContext.Employees.Add(employee);
            // for saving data in database;
            dbContext.SaveChanges();
            // for redirecting data to view page which is Index.cshtml and action method be Index();
            return RedirectToAction("Index");
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
