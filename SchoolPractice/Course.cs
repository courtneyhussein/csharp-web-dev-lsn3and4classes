using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        //Auto-Properties
        public List<string> ClassList { get; set; }
        public List<Student> StudentList { get; set; }
        public int NumOfStudents { get; set; }

        //Constructors
        public Course()
        {
        }
        public Course(List<string> _ClassList, List<Student> _StudentList)
        {
            ClassList = _ClassList;
            StudentList = _StudentList;
            NumOfStudents = StudentList.Count;
        }


        //Method
        public void PrintNumStudents()
        {
            Console.WriteLine($"There are {NumOfStudents} students.");
        }
        public void PrintStudents()
        {
            foreach (Student person in StudentList)
            {
                Console.WriteLine(person.Name);
            }
        }
        public void PrintClasses()
        {
            Console.WriteLine("\nThese are the subjects contained in the course.");
            foreach (string subject in ClassList)
            {
                Console.WriteLine(subject);
            }
        }

    }
}
