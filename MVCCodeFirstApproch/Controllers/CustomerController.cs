using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCodeFirstApproch.Models;


namespace MVCCodeFirstApproch.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;

        public CustomerController(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        //
        public IActionResult Index()
        {
            var customers = dbContext.customers.ToList();
            return View(customers); ;
        }
    }
}
