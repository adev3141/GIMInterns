using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        //made a dictionary 
        public Dictionary<string, string> FindStudent = new Dictionary<string, string>();


        public void AddStudents()
        {     //It just shows the list below you can't add, remove or serch for a specific student. Need to fix that

            Console.WriteLine("Adding the following students: ");
            //Adds number as StudentID(entry key) and name as Name(enry value)
            FindStudent.Add("1", "Alice Johnson");
            FindStudent.Add("2", "Bob Smith");
            FindStudent.Add("3", "Charlie Brown");

            //Display the dictionary contents
            Console.WriteLine("Current Students in the Directory:");
            foreach (var entry in FindStudent)
            {
                Console.WriteLine($"StudentID: {entry.Key}, Name: {entry.Value}");
            }

            
        }
    }

  

}