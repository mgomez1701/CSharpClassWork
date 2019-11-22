using System;
using System.Collections.Generic;
using System.Text;

namespace BoardExample2
{
    public class Person
    {
        //field
        private string name;
        private DateTime dob;
        private string gender;
        // proepties
        
        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }


        }
        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
               
            
        }
        public string Gender // property has to be capatalized
        {
            get
            {
                return gender;

            }
            set
            {
                gender = value;
            }


        }

        public Person (string _name, DateTime _dob, string _gender)
        {
            name = _name;
            dob = _dob;
            gender = _gender;

        }


    }
    
}
