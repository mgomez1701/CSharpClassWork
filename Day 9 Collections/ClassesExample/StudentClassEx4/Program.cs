using System;
using System.Collections.Generic;

namespace StudentClassEx4
{
    class Program
        // create a new course
        //create a student list 
        // add the student list to our course
        // print out the students in that course
    {
        static void Main(string[] args)
        {
            Course october2019CSharp = new Course("C#.NET Oct 2019", DateTime.Parse("10/14/19"), DateTime.Parse("12/20/19")); // we created the course here 

            // at this point only start date is set. we are adding a teacher

            october2019CSharp.Instructor = "Anna B."; // adding to the course
            // creating a list
            List<Student> studentList = new List<Student>
            {
                new Student ("Gus", "Gus","Gus@Gus.Gus.com"),
                new Student ("Jim", "Franklin", "frestbread23@gmail.com"),
                new Student ("Alex", "Gomez", "patchuly05@gmail.com"),
                new Student ("Gerb", "Christ", "theone@gmail.com"),

            };
            october2019CSharp.StudentList = studentList; // adding the student list to the course october2019CSharp

            foreach(Student student in october2019CSharp.StudentList) // printing the student list to the course. 
            {
                Console.WriteLine(student.FirstName);
            }

        }
    }
}
