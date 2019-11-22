using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore2.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCore2.Controllers
{
    public class SchoolDbController : Controller
    {
        private readonly SchoolDbContext _database;
        public SchoolDbController(SchoolDbContext database)
        {
            _database = database;
        }

        public IActionResult ListPeople()
        {
            var personList = _database.Persons.ToList();
            return View(personList);
        }

        //if we are only displaying a page not getting a return
        [HttpGet]
        public IActionResult AddNewPerson()
        {
            return View();
        }

        [HttpPost]
        // user has filled out the form from the AddPerson view
        public IActionResult AddNewPerson(Persons newPerson, string StudentOrInstructor)
        {
            //we need to check model state of newPerson becasue we do not want to add a new person to a database that does not fit
            if (ModelState.IsValid)
            {
                // we are adding a new Person to Person , then we will add if they are Student or Intructor to those tables
                // we MUST RUN THIS NEXT CODE TO SAVE 
                // MUST HAVE//
                _database.Persons.Add(newPerson); 
                _database.SaveChanges(); 

                // now we will store the newPerson in ViewData 

                //TempData["NewPersonId"] = newPerson.Id;
                // checking to see if User selected student or instructor

                //if(StudentOrInstructor == "student")
                //{
                //    return View("AddStudent");
                //}
                //else
                //{
                //    return View("AddInstructor");
                //}
            }  
                return RedirectToAction("ListPeople");

        }
        public IActionResult RemovePerson(int id)
        {
            Persons foundPerson = _database.Persons.Find(id);
            _database.Remove(foundPerson);
            _database.SaveChanges();

            return RedirectToAction("ListPeople");
        }
        [HttpGet]// getting the input from the user
        public IActionResult UpdatePerson(int id)
        {
            Persons foundPerson = _database.Persons.Find(id);

            return View(foundPerson);

        }

        [HttpPost]
        public IActionResult UpdatePerson(Persons updatedPerson)
        {
            // we want to check the model state first and foremost so we know updatedPerson will fit in Persons
            // REMEMBER: The id
            if (ModelState.IsValid)
            {
               Persons databasePerson = _database.Persons.Find(updatedPerson.Id);
                databasePerson.FirstName = updatedPerson.FirstName;
                databasePerson.LastName = updatedPerson.LastName;
                databasePerson.Dob = updatedPerson.Dob;

                _database.Entry(databasePerson).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _database.Update(databasePerson);
                _database.SaveChanges();
            }
            return RedirectToAction("ListPeople");
        }
    }
}