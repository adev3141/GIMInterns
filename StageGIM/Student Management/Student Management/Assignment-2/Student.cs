﻿using System;
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
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

        public List<int> Grade = new List<int>();

     
        

        // Override ToString method to display meaningful student information
        public override string ToString()
        {
            return $"Name: {Name}, Course: {Course}";
        }

        // Method to trigger adding grades through StudentManagement
     //   public void AddGradesForStudent()
       // {
         //   StudentManagement gradeManager = new StudentManagement();
        //    gradeManager.AddGrade(StudentList);  // Passing StudentList to GradeManager
      //  }

        // Method to trigger average calculation through StudentManagement
       // public void CalculateAverages()
       // {
     //       StudentManagement gradeManager = new StudentManagement();
         //   gradeManager.AverageGrade(StudentList);  // Passing StudentList to GradeManager
       // }

        public void FindAndDisplayStudent(StudentManagement studentManagement)
        {//finds the student and displays the student

            //ask the user for student ID
            Console.WriteLine("Give the studentID from the student who you want to find: ");
            string? StudentIdToFind = Console.ReadLine();

            // Using the LookUpStudent method to find the student
            Student? foundStudent = studentManagement.LookUpStudent(StudentIdToFind);

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