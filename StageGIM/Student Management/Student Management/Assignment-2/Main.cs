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
            bool Running = true;

            while (Running) 
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Grade");
                Console.WriteLine("3. Display Average Grade");
                Console.WriteLine("4. Add student to HelpDesk Queue");
                Console.WriteLine("5. Look Up Student");
                Console.WriteLine("6. Remove Student");
                Console.WriteLine("7. Update Student");
                Console.WriteLine("8. Find and Display Student");
                Console.WriteLine("9. Exit");

                string Input =Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        kid.StudentList.Add(man.AddStudent());
                        break;
                    case "2":
                        man.AddGrade(kid.StudentList);
                        break;
                    case "3":
                        man.AverageGrade(kid.StudentList);
                        break;
                    case "4":
                        help.AddToQueue();
                        break;
                    case "5":
                        man.LookUpStudent(kid.StudentID);
                        break;
                    case "6":
                        man.RemoveStudent();
                        break;
                    case "7":
                        man.UpdateStudent();
                        break;
                    case "8":
                        kid.FindAndDisplayStudent(man);
                        break;
                    case "9":
                        Running = false;
                        break;
                }

            }      
        }
    }
}