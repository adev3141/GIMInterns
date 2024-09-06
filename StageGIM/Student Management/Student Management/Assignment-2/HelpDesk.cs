using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem
{
    internal class HelpDeskSystem
    {
        //queue for HelpDesk
        Queue<Student> HelpDeskQueue = new Queue<Student>();
        Student StudentHelpDesk { get; set; } = new Student();

        public void AddToQueue()//need to see if it adds in fifo manner
        {//adds student to the Queue but does not display the Queue 

            Console.WriteLine("Pleade enter your Name: ");
            string StudentName = Console.ReadLine();

            Console.WriteLine("Please enter your Student ID: ");
            string studentID = Console.ReadLine();

            //creates a new student object
            Student student = new Student { Name = StudentName, StudentID = studentID };
            this.HelpDeskQueue.Enqueue(student);
        
            Console.WriteLine($"You have been added to the queue.");

            // Displays the contents of the queue.
            Console.WriteLine("Current queue:");
            foreach (var Student in this.HelpDeskQueue)
            {
                Console.WriteLine($"{Student.Name} (ID: {Student.StudentID})");
            }
        }

    }
}
