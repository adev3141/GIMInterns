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
        Queue<string> HelpDeskQueue = new Queue<string>();
        Student StudentHelpDesk { get; set; } = new Student();
        
        public void AddToQueue()
        {//adds student to the Queue but does not display the Queue 
            Console.WriteLine("Please enter your Student ID to enter the queue:");
            string studentID = Console.ReadLine();

            // Adds the student ID to the queue
            this.HelpDeskQueue.Enqueue(studentID);

            Console.WriteLine("You have been added to the queue.");

        }

        public void HelpDesk()
        {
            Console.WriteLine("Hello, this is the queue for the help desk...");
            AddToQueue();
         
        }
    }
}
