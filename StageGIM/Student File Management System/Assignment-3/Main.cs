using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;



namespace StudentFileManagement
{
    class MainWindow
    {
        static void Main(string[] args)
        {
            ManageStudent manageStudent = new ManageStudent();
            Serialization serialization = new Serialization();
            Student student = new Student();
            bool Running = true;
            // Specify the path for the JSON file
            string? filePathJson = "students.json";
            // Specify the path for the XML file
            string filePathXml = "students.xml";


            while (Running)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Remove student");
                Console.WriteLine("3. Serialize To Json File");
                Console.WriteLine("4. Deserialize From Json File");
                Console.WriteLine("5. Serialize To XML File");
                Console.WriteLine("6. Deserialize from XML File");
                Console.WriteLine("7. Exit");

                string Input = Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        manageStudent.AddStudent();
                        break;
                    case "2":
                        manageStudent.RemoveStudent();
                        break;
                    case "3":
                        // Serialize the list of students to the JSON file
                        serialization.SerializeToFile(manageStudent.StudentList, filePathJson);
                        Console.WriteLine("Students serialized to JSON file successfully.");
                        break;
                    case "4":
                        // Deserialize the list of students from the file
                        List<Student> deserializedStudentsJson = serialization.DeserializeFromFile(filePathJson);
                        Console.WriteLine("Students deserialized from JSON file successfully.");

                        // Print out the deserialized students
                        foreach (var studentVar in deserializedStudentsJson)
                        {
                            Console.WriteLine($"Name: {studentVar.Name}");
                        }
                        break;
                    case "5":
                        // Serialize the list of students to a file
                        serialization.SerializeToXML(manageStudent.StudentList, filePathXml);
                        Console.WriteLine("Students serialized to file successfully.");
                        break;
                    case "6":
                        // Deserialize the list of students from the XML file
                        List<Student> deserializedStudentsXml = serialization.DeserializeFromXML(filePathXml);
                        Console.WriteLine("Students deserialized from XML file successfully.");

                        // Print out the deserialized students from XML
                        Console.WriteLine("Deserialized Students from XML:");
                        foreach (var studentVar in deserializedStudentsXml)
                        {
                            Console.WriteLine($"Name: {studentVar.Name}");
                        }
                        break;
                    case "7":
                        Running = false;
                        break;

                }

            }
        }

    }
    
}

           