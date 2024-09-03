using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Student
    {
        
        string? name;
        string? course;
        string? studentClass;
        int studentID;
        List<int> grades = new List<int>();

        public int StudentID { get => studentID; set => studentID = value; }
        public string Name { get => name; set => name = value; }
        public string Course { get => course; set => course = value; }
        public List<int> Grades { get => grades; set => grades = value; }
        public string StudentClass { get => studentClass; set => studentClass = value; }

        public void SetStudent(string name, string course, List<int> grades, int studentID, string studentClass)
        {
            this.StudentClass = studentClass;
            this.StudentID = studentID; 
            this.Name = name;
            this.Course = course;
            this.Grades = grades;
        }
    }
}
