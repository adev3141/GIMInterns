﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem
{
    internal class StudentManagement
    {   
        Student Student { get; set; } = new Student();
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
                while (Student.FindStudent.ContainsKey(StudentID))
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
                Student.FindStudent.Add(StudentID, NewStudent);
            }

            //Display the dictionary contents
            Console.WriteLine("Current Students in the Directory:");
            foreach (var entry in Student.FindStudent)
            {
                Console.WriteLine($"StudentID: {entry.Key}, Name: {entry.Value}");
            }

        }

        public Student LookUpStudent(string StudentID)
        {
            // Console.WriteLine("Give the studentID from the student who you want to find: ");
            // Check if the studentId exists in the dictionary
            if (Student.FindStudent.ContainsKey(StudentID))
            {
                // If it exists, return the corresponding Student object
                return Student.FindStudent[StudentID];
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
