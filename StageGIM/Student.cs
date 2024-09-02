using LibraryManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem
{
    internal class Student
    {
        public string? StudentID { get; set; }
        public string? Name { get; set; }
        public string? Course { get; set; }

        public List<int> Grade = new List<int>();

        public List<Student> StudentList = new List<Student>();

        public Dictionary<string, string> FindStudent = new Dictionary<string, string>();

    }

    public void AddStudents()
    {
        Console.WriteLine("AddStudents");
        FindStudent.Add("101", "Alice Johnson");
        FindStudent.Add("102", "Bob Smith");
        FindStudent.Add("103", "Charlie Brown");
    }

}