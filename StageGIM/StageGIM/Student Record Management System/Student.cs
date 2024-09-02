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


    }

}
