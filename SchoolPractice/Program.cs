using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student studentOne = new Student("Courtney", 1234);
            Student studentTwo = new Student("Hakim", 8765);

            studentOne.PrintInfo();

            studentTwo.Gpa = 3.75;
            studentTwo.NumberOfCredits = 20;

            studentTwo.PrintInfo();

            List<string> classes = new List<string> { "History", "Geography", "Math" };
            List<Student> students = new List<Student> { studentOne, studentTwo };

            Course course1 = new Course();
            Course course2 = new Course(classes, students);

            course1.PrintNumStudents();
            course2.PrintNumStudents();
            course2.PrintStudents();
            course2.PrintClasses();

            Teacher teacherOne = new Teacher("John", "Smith");
            Teacher teacherTwo = new Teacher("Jane", "Doe");

            teacherTwo.YearsTeaching = 10;
            teacherTwo.Subject = "History";

            teacherOne.PrintDetails();
            teacherTwo.PrintDetails();



        }
    }
}
