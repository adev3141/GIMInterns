using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class School
    {
        static int studentID=0;
        Dictionary<int, Student> studentLookUp = new Dictionary<int, Student>();
        Dictionary<int, Student> AllClasses = new Dictionary<int, Student>();


        static List<Student> students = new List<Student>();
        public int StudentID { get => studentID; set => studentID = value; }
        internal List<Student> Students { get => students; set => students = value; }
        internal Dictionary<int, Student> StudentLookUp { get => studentLookUp; set => studentLookUp = value; }
      

        public void AddStudent(string name, string course, List<int> grades, string studentClass) {
            studentID++;    
            Student newStudent = new Student();
            newStudent.SetStudent(name, course, grades, studentID, studentClass);
            Students.Add(newStudent);
            Console.WriteLine("Student Added!");
            StudentLookUp.Add(studentID, newStudent);
        
        }
        
        
    }
}
