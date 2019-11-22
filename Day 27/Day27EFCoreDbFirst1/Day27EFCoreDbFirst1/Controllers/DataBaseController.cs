using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day27EFCoreDbFirst1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day27EFCoreDbFirst1.Controllers
{
    public class DataBaseController : Controller
    {

        private readonly NorthwindContext _context;
        public DataBaseController(NorthwindContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // in order to list out one of the tables 
            //_context is saying we are stepping in the database, and then have access to all the tables
            var employeeList = _context.Employees.ToList(); // .toList will add all the employees in a list
            return View(employeeList);
        }
    }
}