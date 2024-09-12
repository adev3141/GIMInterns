using Student_Management.Assignment_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem
{
    internal class StudentManagement
    {
        ClassRoom ClassRoom = new ClassRoom();
        Student Student { get; set; } = new Student();
        //made a dictionary 
        public Dictionary<string, Student> FindStudent { get; set; } = new Dictionary<string, Student>();

        public Student LookUpStudent(string StudentID)
        {
             Console.WriteLine("Give the studentID from the student who you want to find: ");
            // Checks if the studentId exists in the dictionary
            if (FindStudent.ContainsKey(StudentID))
            {
                // If it exists, return the corresponding Student object
                return FindStudent[StudentID];
            }
            else
            {
                // If the studentId does not exist, return null or handle accordingly
                Console.WriteLine("Student not found.");
                return null;
            }

        }
        public Student AddStudent()
        {//You can add students to the Dictionary FindStudent

            int NumberOfStudents;//stores how many students user wants to add
            Console.WriteLine("How many students do you want to add? ");

            //  Valid number to be added check
            while (!int.TryParse(Console.ReadLine(), out NumberOfStudents) || NumberOfStudents <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
               
            }


            for (int Num = 0; Num < NumberOfStudents; Num++)
            {
                Console.WriteLine($"Enter the studentId for the student {Num + 1}: ");
                string? StudentID = Console.ReadLine();

                // Check if the StudentID is already in use
                while (FindStudent.ContainsKey(StudentID))
                {
                    Console.WriteLine("This StudentID is already in use. Please enter a different StudentID:");
                    StudentID = Console.ReadLine();
                }

                Console.WriteLine($"Enter the Name for student {Num + 1}:");
                string? Name = Console.ReadLine();

                Console.WriteLine($"Enter the Course for student {Num + 1}:");
                string? course = Console.ReadLine();

                // Create a new Student object
                Student NewStudent = new Student
                {
                    StudentID = StudentID,
                    Name = Name,
                    Course = course
                };

                // Add the student to the StudentList
                ClassRoom.StudentList.Add(NewStudent);

                // Add the student to the dictionary
                FindStudent.Add(StudentID, NewStudent);
                return NewStudent;
            }
            
            //Display the dictionary contents
            Console.WriteLine("Current Students in the Directory:");
            foreach (var entry in FindStudent)
            {
                Console.WriteLine($"StudentID: {entry.Key}, Name: {entry.Value}");
            }
            return null;
        }
        public void AddGrade(List<Student> StudentList)//asks for the grade(s) of the student and puts them in list Grade + displays the added grade at the end
        {
          //  Student student = new Student { Grade = new List<int>() };//create a new student
            
            int NumberOfGrades;//stores how many grades the user wants to add

            Console.WriteLine("Enter the student's name:");
            string NameChoice = Console.ReadLine();

            Console.WriteLine("How many grades do you want to add? ");

            //  Valid number check
            while (!int.TryParse(Console.ReadLine(), out NumberOfGrades) || NumberOfGrades <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
            }

            // Loops based on the number of grades the user wants to input
            for (int Teller = 0; Teller < NumberOfGrades; Teller++)
            {
                int NumberGrade; //stores the grade number of student
                Console.WriteLine($"Enter grade number {Teller + 1}: ");

                // Check for valid grade input
                while (!int.TryParse(Console.ReadLine(), out NumberGrade) || NumberGrade < 0 || NumberGrade > 100)
                {
                    Console.WriteLine("Please enter a valid grade between 0 and 100.");
                }
                int counter = 0;
                foreach (Student k in StudentList) 
                {
                    counter++;
                    if (k.Name == NameChoice) 
                    {
                        ClassRoom.StudentList[counter - 1].Grade.Add(NumberGrade);
                        Console.WriteLine("grade toegevoegd");
                    }
                
                }
              //  Student.Grade.Add(NumberGrade);//adds grade put in to List Grade

            }


        }
        public void AverageGrade(List<Student> StudentList)
        {//needs to be able to calculate average for each student and overall class average.does it just for 1 student for now

            if (ClassRoom.StudentList.Count() == 0)//looks if there are students in the list
            {
                Console.WriteLine("No student avalable");
                return;
            }

            foreach (var studentTeller in ClassRoom.StudentList)//lookst if there are grades in list grade
            {
                if (studentTeller.Grade.Count == 0)
                {
                    Console.WriteLine($"{studentTeller.Name} has no grades.");
                    continue;
                }

                //calculates 
                int sum = studentTeller.Grade.Sum();
                double Average = (double)sum / studentTeller.Grade.Count;
                Console.WriteLine($"{studentTeller.Name} average grade is: {Average}");
                ;
            }

        }


        public void UpdateStudent()
        {// Asking for the StudentID of the student to update
            Console.WriteLine("Enter the StudentID of the student you want to update:");
            string? StudentIdUpdate = Console.ReadLine();

            //looking if there is a student with that StudentID
            Student? StudentToUpdate = LookUpStudent(StudentIdUpdate);//goes wrong here
            Console.WriteLine("comes here before loop?");

            if (StudentToUpdate != null)
            {
                Console.WriteLine($"Updating details for{StudentToUpdate.Name}");

                Console.WriteLine("Enter new name: ");
                string NewName = Console.ReadLine();

                if (!string.IsNullOrEmpty(NewName))
                {
                    StudentToUpdate.Name = NewName;
                }

                Console.WriteLine("Enter new cource: ");
                string NewCource = Console.ReadLine();

                if (!string.IsNullOrEmpty(NewCource))
                {
                    StudentToUpdate.Course = NewCource;
                }

                //finds the student in list and updates it
                var StudentInList = ClassRoom.StudentList.FirstOrDefault(s => s.StudentID == StudentIdUpdate);
                if (StudentInList != null)
                {
                    StudentInList.Name = StudentToUpdate.Name;
                    StudentInList.Course = StudentToUpdate.Course;
                }
                //Update the dictionary
                FindStudent[StudentInList.StudentID] = StudentToUpdate;

                Console.WriteLine("The student has been updated");

            }
            else
            {
                Console.WriteLine("There is no such student");
            }
        }
        public void RemoveStudent()
        {//You can remove students from the Dictionary FindStudent

            int NumberOfStudentsToRemove;//stores how many students user wants to remove
            Console.WriteLine("How many students do you want to remove? ");

            //  Valid number to be added
            while (!int.TryParse(Console.ReadLine(), out NumberOfStudentsToRemove) || NumberOfStudentsToRemove <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
            }


            for (int Num = 0; Num < NumberOfStudentsToRemove; Num++)
            {
                Console.WriteLine($"Enter the studentId for the student you want to remove {Num + 1}: ");
                string? StudentID = Console.ReadLine();

                Console.WriteLine($"Enter the Name for student you want to remove {Num + 1}:");
                string? Name = Console.ReadLine();

                // Create a new Student object to then remove it
                Student NewStudent = new Student
                {
                    StudentID = StudentID,
                    Name = Name,

                };

                // remove the student to the StudentList
                ClassRoom.StudentList.Remove(NewStudent);

                // remove the student to the dictionary
                FindStudent.Remove(StudentID, out NewStudent);
            }

            //Display the dictionary contents
            Console.WriteLine("Current Students in the Directory after removal:");
            foreach (var entry in FindStudent)
            {
                Console.WriteLine($"StudentID: {entry.Key}, Name: {entry.Value}");
            }
        }

      

    }
}
