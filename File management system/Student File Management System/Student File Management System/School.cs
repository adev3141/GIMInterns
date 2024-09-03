using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_File_Management_System
{
    public class School
    {

         List<Student> students = new List<Student>();

        internal List<Student> Students { get => students; set => students = value; }
    }
}
