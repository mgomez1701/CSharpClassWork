using System;
using System.Collections.Generic;

namespace StudentClassEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Classmates> classList = new List<Classmates>// creating a list without .Add
            {
                new Classmates ("bill", "Buffulo", "Buffulo Chicken Wings", "Football", 7), // using a comma becasue we are taking in more input
                new Classmates("Stitch", "Hawaii", "All of it", "Findin his family", 626),
                new Classmates("Oliver" , "Wales", "crepes", "Playing the Banjo", 4)
            }; // do the semicolon after these becasue we are creating the list here. 

            foreach(Classmates classmate in classList)
            {
                classmate.PrintInfo(); // this is a nonstatic method it needs classmates. to run. it doesnt takein parameters
            }
        }
    }
}
