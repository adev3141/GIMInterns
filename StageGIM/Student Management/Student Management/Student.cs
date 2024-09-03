using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentRecordManagementSystem
{
    internal class Student
    {
        public string? StudentID { get; set; }
        public string? Name { get; set; }
        public string? Course { get; set; }

        public List<int> Grade = new List<int>();

        public List<Student> StudentList = new List<Student>();

        //made a dictionary 
        public Dictionary<string, Student> FindStudent { get; set; } = new Dictionary<string, Student>();

        // Override ToString method to display meaningful student information
        public override string ToString()
        {
            return $"Name: {Name}, Course: {Course}";
        }

        public void AddStudent()
        {//You can add students to the Dictionary FindStudent

            int NumberOfStudents;//stores how many students user wants to add
            Console.WriteLine("How many students do you want to add? ");

            //  Valid number to be added
            while (!int.TryParse(Console.ReadLine(), out NumberOfStudents) || NumberOfStudents <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
            }


            for (int Num = 0; Num < NumberOfStudents; Num++)
            {
                Console.WriteLine($"Enter the studentId for the student {Num + 1}: ");
                string? StudentID = Console.ReadLine();

                // Check if the StudentID is already in use
                while (FindStudent.ContainsKey(StudentID))
                {
                    Console.WriteLine("This StudentID is already in use. Please enter a different StudentID:");
                    StudentID = Console.ReadLine();
                }

                Console.WriteLine($"Enter the Name for student {Num + 1}:");
                string? Name = Console.ReadLine();

                Console.WriteLine($"Enter the Course for student {Num + 1}:");
                string? course = Console.ReadLine();

                // Create a new Student object
                Student NewStudent = new Student
                {
                    StudentID = StudentID,
                    Name = Name,
                    Course = course
                };

                // Add the student to the StudentList
                StudentList.Add(NewStudent);

                // Add the student to the dictionary
                FindStudent.Add(StudentID, NewStudent);
            }

            //Display the dictionary contents
            Console.WriteLine("Current Students in the Directory:");
            foreach (var entry in FindStudent)
            {
                Console.WriteLine($"StudentID: {entry.Key}, Name: {entry.Value}");
            }


        }

        public Student LookUpStudent(string StudentID)
        {
           // Console.WriteLine("Give the studentID from the student who you want to find: ");
            // Check if the studentId exists in the dictionary
            if (FindStudent.ContainsKey(StudentID))
            {
                // If it exists, return the corresponding Student object
                return FindStudent[StudentID];
            }
            else
            {
                // If the studentId does not exist, return null or handle accordingly
                Console.WriteLine("Student not found.");
                return null;
            }

        }

        public void FindAndDisplayStudent()
        {
            //ask the user for student ID
            Console.WriteLine("Give the studentID from the student who you want to find: ");
            string? StudentIdToFind = Console.ReadLine();

            // Using the LookUpStudent method to find the student
            Student? foundStudent = LookUpStudent(StudentIdToFind);

            // Displays the result
            if (foundStudent != null)
            {
                Console.WriteLine($"Student Found: {foundStudent.Name}, Course: {foundStudent.Course}");
            }
            else
            {
                Console.WriteLine("No student with that ID exists.");
            }
        }
    }

  

}