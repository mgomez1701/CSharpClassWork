using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreDAy28Ex1.Controllers.Context;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDAy28Ex1.Controllers
{
    public class CompanyDbController : Controller
    {

        // we need to bring database into the controller Part 7 of page
        private readonly CompanyDbContext _database;

        public CompanyDbController(CompanyDbContext database)
        {
            _database = database;
        }

        // listing out all of the departments
        // include 3 buttons: Update, Delete, List Employees 
        public IActionResult DepartmentIndex()
        {
            return View(_database.Department.ToList());

        }
        public IActionResult EmployeeIndex()
        {
            return View(_database.Employees.ToList());

        }

        public IActionResult ListEmployeesByDepartment(int id)
        {
            //creating a variable employee
            var employees = _database.Employees.Where(employee => employee.DepartmentId == id).ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
            if (ModelState.IsValid)
            {
                _database.Department.Add(department);
                _database.SaveChanges();
                return RedirectToAction("DepartmentIndex");
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateDepartment(int id)
        {
            return View(_database.Department.Find(id));
        }
        
        [HttpPost]
        public IActionResult UpdateDepartment(Department newDepartment)
        {
            if (ModelState.IsValid)
            {
                Department oldDepartment = _database.Department.Find(newDepartment.DepartmentId);
                oldDepartment.Name = newDepartment.Name;
                oldDepartment.Location = newDepartment.Location;
                oldDepartment.Type = newDepartment.Type;
                oldDepartment.Budget = newDepartment.Budget;

                _database.Entry(oldDepartment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                _database.Update(oldDepartment);
                _database.SaveChanges();
            }
            return RedirectToAction("DepartmentIndex");
        }
        public IActionResult DeleteDepartment(int id)
        {
            var foundDepartment = _database.Department.Find(id);
            if (foundDepartment != null)
            {
                // moved here after wew create the MoveEmployee method
                MoveEmployees(id);
                _database.Department.Remove(foundDepartment);
                _database.SaveChanges();
            }
            return RedirectToAction("DepartmentIndex");

        }
        private void MoveEmployees(int id)
        {
            // we need to save the employees in a department if department gets erased
            // COPIED from the LISTEMPLOYEESBYDEPARTMENT
            var employees = _database.Employees.Where(employee => employee.DepartmentId == id).ToList();
            foreach (Employee employee in employees)
            {
                employee.DepartmentId = 5;
            }
        }

        [HttpGet]
        public IActionResult UpdateEmployee(int id)
        {
            return View(_database.Employees.Find(id));
        }

        [HttpPost]
        public IActionResult UpdateEmployee(Employee newEmployee)
        {
            if (ModelState.IsValid)
            {
                Employee oldEmployee = _database.Employees.Find(newEmployee.EmployeeId);
                oldEmployee.FirstName = newEmployee.FirstName;
                oldEmployee.LastName = newEmployee.LastName;
                oldEmployee.Email = newEmployee.Email;
                oldEmployee.DepartmentId = newEmployee.DepartmentId;

                _database.Entry(oldEmployee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _database.Update(oldEmployee);
                _database.SaveChanges();

            }
            return RedirectToAction("EmployeeIndex");
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _database.Employees.Add(employee);
                _database.SaveChanges();
                return RedirectToAction("EmployeeIndex");
            }
            return View();
        }
    }
}