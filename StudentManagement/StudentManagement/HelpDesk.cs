using System;
using System.Collections.Generic;

namespace StudentManagement
{
  
         class Helpdesk // Made public for accessibility if needed
        {
            List<Student> queue = new List<Student> ();

        internal List<Student> Queue { get => queue; set => queue = value; }

        public int AddStudentToQueue(Student newStudent)
            {
                Queue.Add (newStudent);
                return Queue.Count; // Example return value
            }
            public int RemoveStudentFromQueue(Student newStudent)
            {
                Queue.Remove(newStudent);
                return Queue.Count; // Example return value
            }
        }
    
}
