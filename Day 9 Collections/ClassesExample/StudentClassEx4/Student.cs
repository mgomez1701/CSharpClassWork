using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassEx4
{
    class Student
    {

        // fields
        private string firstName;
        private string lastName;
        private string major;
        private double gpa;
        private string email;
        #region properties

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }

        }

        #endregion properties
        public Student()
        {

        }
        public Student (string _firstname, string _lastname,   string _email)
        {
            firstName = _firstname;
            lastName = _lastname;
            email = _email;

        }

    }
}
