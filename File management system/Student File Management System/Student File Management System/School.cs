using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_File_Management_System
{
    public class School
    {

         List<Student> students = new List<Student>();

        internal List<Student> Students { get => students; set => students = value; }
        public int getIndexOfStudent(School school, int studentID) {
            int index = 0;
            foreach (Student i in school.Students)
            {
                if (i.StudentID == studentID)
                {
                     index = school.Students.IndexOf(i);
                    

                }


            }
            return index; 
        }
    }
}
