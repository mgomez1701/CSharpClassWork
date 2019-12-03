using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakingAPIs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MakingAPIs.Controllers
{
    //STEP 5 CREATE ROUTING
    [Route("api/[controller]")]
    //STEP 6 
    [ApiController]
    //STEP 3.5 Change Controller to ControllerBase. ControllerBase is where the Routing will inherit from
    public class CompanyController : ControllerBase
    {

        //STEP 4 DEPENDECY INJECTION 

        private readonly CompanyDbContext _database;

        public CompanyController(CompanyDbContext database)
        {
            _database = database;
        }
        // end of step 4

        // Step 7 Creating CRUD Actions

        //GET: api/Company
        //Step 8 create async and add   [HttpGet]
        [HttpGet]
        public async Task<ActionResult<List<Employees>>> GetEmployees()
        {
            // returning a List of employees
            return await _database.Employees.ToListAsync();
            //step 9 run with Debugging and check the URL https://localhost:44340/api/Company
        }

        //step 10 overload the GET Method
        // GET: api/Company/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Employees>> GetEmployeeById(int id)
        {
            //step 11 create a variable called employee
            var employee = await _database.Employees.FindAsync(id);
            // step 12 check to make sure the employee ID even exsist
            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        //Adding to the API
        //POST: api/Company
        [HttpPost]
        public async Task<ActionResult<Employees>> PostEmployee(Employees employee)
        {
            //Step 13 ADD the employee to the list
            _database.Employees.Add(employee);
            await _database.SaveChangesAsync();
            //Step 14 Create an action that returns a 201 status code if successful. This is the STANDARD response that a creates a new resource on the server.
            // This also adds a loaction to the response, specifies the URI of the newly created employee.
            //This also references the GetEmployeeId action to create the location header's URI.
            //      C# "nameof" is used to avoid hard-coding the action the CreateAtAction call.

            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.EmployeeId }, employee);
        }

        //PUTTING to the API
        // PUT: api/Company/{id}

        [HttpPut("{id}")]
        // step 15 creating async BUT we are not giving it anything.
        // Parameters are the ID of the new employee and the actual Employee
        public async Task<ActionResult>PutEmployee(int id, Employees employee)
        {
            //checking to make sure the employee matches by id
            if(id!= employee.EmployeeId)
            {
                return BadRequest();
            }

            _database.Entry(employee).State = EntityState.Modified;
            await _database.SaveChangesAsync();
            // we return no content instead of void is to return the status code.
            return NoContent();
            //RESPONSE: 204 (No Content) This requires the client to send over a full entity and not just the changes. 
            // To support partial updates we would use Http Patchh
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult>DeleteEmployee(int id)
        {
            // create a var employee
            // basically the same as the HttpGet Method
            var employee = await _database.Employees.FindAsync(id);
            if(employee == null)
            {
                return NotFound();
            }
            _database.Employees.Remove(employee);
            await _database.SaveChangesAsync();
            return NoContent();
        }

    }
}