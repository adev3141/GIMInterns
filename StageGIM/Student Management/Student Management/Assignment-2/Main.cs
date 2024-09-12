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
                    //adds a student 
                    case "1":
                        kid.StudentList.Add(man.AddStudent());
                        break;
                    //adds a grade
                    case "2":
                        man.AddGrade(kid.StudentList);
                        break;
                    //displays the average grade
                    case "3":
                        man.AverageGrade(kid.StudentList);
                        break;
                    //adds student to the help desk queue
                    case "4":
                        help.AddToQueue();
                        break;
                    //you can look up a student 
                    case "5":
                        man.LookUpStudent(kid.StudentID);
                        break;
                    //you can remove a student
                    case "6":
                        man.RemoveStudent();
                        break;
                    //you can change something of the student like the name, grade ect.
                    case "7":
                        man.UpdateStudent();
                        break;
                    //you can look up a student and display said student
                    case "8":
                        kid.FindAndDisplayStudent(man);
                        break;
                    //you stop running the application
                    case "9":
                        Running = false;
                        break;
                }

            }      
        }
    }
}