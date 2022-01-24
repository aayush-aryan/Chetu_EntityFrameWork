using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCodeFirstApproch.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var emps = new List<string>() { "Rahul", "Deepak", "John", "Ajay" };
            ViewBag.employees = emps;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
