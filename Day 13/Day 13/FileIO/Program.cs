using System;
using System.Collections.Generic;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();

            StreamReader reader = new StreamReader("../../../Student.txt");
            string line = reader.ReadLine();
            while(line != null)
            {
                names.Add(line);
                line = reader.ReadLine();
            }
            reader.Close();

            foreach(string name in names)
            {
                Console.WriteLine(name );
            }

            names.Add("Harry Potter");

            StreamWriter writer  = new StreamWriter("../../../Students.txt");
            foreach( string name in names)
            {
                writer.WriteLine(name);
            }
            writer.Close();
            //StreamWriter writer = new StreamWriter("../../../students.txt");
            //// talk to writer objeect
            //writer.WriteLine("Hank Hill");
            //// we need to close the writer
            //writer.Close();

            //StreamReader reader = new StreamReader("../../../students.txt");
            //List<string> names = new List<string> ()

            ////writer = new StreamWriter("../../../students.txt");
            ////writer.WriteLine("Jason Vorhees");
            ////writer.Close();

        }
    }
}
