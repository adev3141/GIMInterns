using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_File_Management_System
{
     public class Student
    {
        int studentID = 0;
        string name = "";
        string course = "";
        List<int> grades = new List<int>();

      
        public string Name { get => name; set => name = value; }
        public string Course { get => course; set => course = value; }
        public List<int> Grades { get => grades; set => grades = value; }
        public int StudentID { get => studentID; set => studentID = value; }

        public void setStudent(string name, string course) { 
            StudentID = StudentID + 1;
            this.name = name;
            this.course = course;

        
        
        }
    }
}
