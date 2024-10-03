using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StudentFileManagement
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        // Parameterless constructor for XML serialization
        public Student() { }

        // Constructor with parameters
        public Student(string name, int age, string course)
        {
            Name = name;
            Age = age;
            Course = course;
        }


    }
}
