using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }

        //Constructor
        public Teacher (string _FirstName, string _LastName)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            Subject = "How To Study";
            YearsTeaching = 0;
        }

        //Method
        public void PrintDetails()
        {
            Console.WriteLine($"{FirstName} {LastName} teaches \"{Subject}\" and has been teaching for {YearsTeaching} years.");
        }

    }
}
