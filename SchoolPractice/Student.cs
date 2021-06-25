using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        //Auto-implemented properties.
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        //Constructor
        public Student (string _Name, int _StudentId)
        {
            Name = _Name;
            StudentId = _StudentId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        //Method
        public void PrintInfo()
        {
            Console.WriteLine($"{Name} has student ID {StudentId}, {NumberOfCredits} credits, and a GPA of {Gpa}. ");
        }




    }
}
