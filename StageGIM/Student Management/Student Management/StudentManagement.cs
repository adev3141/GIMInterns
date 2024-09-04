using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem
{
    internal class StudentManagement
    {
        Student Student { get; set; } = new Student();
        //made a dictionary 

        public Dictionary<string, Student> FindStudent { get; set; } = new Dictionary<string, Student>();
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
                Student.StudentList.Add(NewStudent);

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
        public void UpdateStudent()
        {// Asking for the StudentID of the student to update
            Console.WriteLine("Enter the StudentID of the student you want to update:");
            string? StudentIdUpdate = Console.ReadLine();

            //looking if there is a student with that StudentID
            Student? StudentToUpdate = Student.LookUpStudent(StudentIdUpdate);
            Console.WriteLine("comes here before loop?");

            if (StudentToUpdate != null)
            {
                Console.WriteLine($"Updating details for{StudentToUpdate.Name}");

                Console.WriteLine("Enter new name: ");
                string NewName = Console.ReadLine();

                if (!string.IsNullOrEmpty(NewName))
                {
                    StudentToUpdate.Name = NewName;
                }

                Console.WriteLine("Enter new cource: ");
                string NewCource = Console.ReadLine();

                if (!string.IsNullOrEmpty(NewCource))
                {
                    StudentToUpdate.Course = NewCource;
                }

                //finds the student in list and updates it
                var StudentInList = Student.StudentList.FirstOrDefault(s => s.StudentID == StudentIdUpdate);
                if (StudentInList != null)
                {
                    StudentInList.Name = StudentToUpdate.Name;
                    StudentInList.Course = StudentToUpdate.Course;
                }
                //Update the dictionary
                FindStudent[StudentInList.StudentID] = StudentToUpdate;

                Console.WriteLine("The student has been updated");

            }
            else
            {
                Console.WriteLine("There is no such student");
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
                    StudentID = StudentID,
                    Name = Name,

                };

                // remove the student to the StudentList
                Student.StudentList.Remove(NewStudent);

                // remove the student to the dictionary
                FindStudent.Remove(StudentID, out NewStudent);
            }

            //Display the dictionary contents
            Console.WriteLine("Current Students in the Directory after removal:");
            foreach (var entry in FindStudent)
            {
                Console.WriteLine($"StudentID: {entry.Key}, Name: {entry.Value}");
            }
        }



    }
}
