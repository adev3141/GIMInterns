using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRecordManagementSystem;

namespace StudentRecordManagementSystem
{
    class MainWindow
    {
        static void Main(string[] args)
        {
            Student kid = new Student();
            HelpDeskSystem help = new HelpDeskSystem();
            StudentManagement man = new StudentManagement();
     

            man.AddStudent();
             //help.HelpDesk();
           // help.AddToQueue();
           // kid.LookUpStudent("");
           //kid.RemoveStudent();
           man.UpdateStudent();
            //kid.FindAndDisplayStudent();
           
           // kid.AddToQueue();
        }
    }
}