using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFileManagement
{
    internal class ManageStudent
    {

        public List<Student> StudentList = new List<Student>();
        public void AddStudent()
        {
            int NumberOfStudents;//stores how many students user wants to add
            Console.WriteLine("How many students do you want to add? ");

            //  Valid number to be added check
            while (!int.TryParse(Console.ReadLine(), out NumberOfStudents) || NumberOfStudents <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");

            }


            for (int Num = 0; Num < NumberOfStudents; Num++)
            {
                Console.WriteLine($"Enter the Name for student {Num + 1}:");
                string? Name = Console.ReadLine();

                Console.WriteLine($"Enter the Course for student {Num + 1}:");
                string? course = Console.ReadLine();

                // Create a new Student object
                Student NewStudent = new Student
                {
                    Name = Name,
                    Course = course
                };

                // Add the student to the StudentList
                StudentList.Add(NewStudent);

            }
           
        }


        public void RemoveStudent()
        {//You can remove students from the Dictionary FindStudent

            int NumberOfStudentsToRemove;//stores how many students user wants to remove
            Console.WriteLine("How many students do you want to remove? ");

            //  Valid number to be added
            while (!int.TryParse(Console.ReadLine(), out NumberOfStudentsToRemove) || NumberOfStudentsToRemove <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
            }


            for (int Num = 0; Num < NumberOfStudentsToRemove; Num++)
            {
                Console.WriteLine($"Enter the studentId for the student you want to remove {Num + 1}: ");
                string? StudentID = Console.ReadLine();

                Console.WriteLine($"Enter the Name for student you want to remove {Num + 1}:");
                string? Name = Console.ReadLine();

                // Create a new Student object to then remove it
                Student NewStudent = new Student
                {
                    Name = Name,

                };

                // remove the student to the StudentList
                StudentList.Remove(NewStudent);

            }
        }


    }
}
