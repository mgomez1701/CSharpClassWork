using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day24LastExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day24LastExample.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddStudent()
        {
            return View();
        }
        public IActionResult DisplayStudent(Student newStudent) // have to add using statement uptop
        {
            if (ModelState.IsValid)
            {
                return View(newStudent);
            }
            else
            {
                return View("AddStudent");
            }
        }

    }
}