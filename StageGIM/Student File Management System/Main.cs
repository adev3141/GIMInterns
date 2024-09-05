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
            // Create a list of Student objects hard codded
            var students = new List<Student>
            {
                new Student("Alice", 20, "Mathematics"),
                new Student("Bob", 22, "Computer Science")
            };

            // Create an instance of the Serialization class
            Serialization serialization = new Serialization();


            // Specify the path for the JSON file
            string filePathJson = "students.json";

            // Serialize the list of students to the JSON file
            serialization.SerializeToFile(students, filePathJson);
            Console.WriteLine("Students serialized to JSON file successfully.");

            // Deserialize the list of students from the file
            List<Student> deserializedStudentsJson = serialization.DeserializeFromFile(filePathJson);
            Console.WriteLine("Students deserialized from JSON file successfully.");

          // Print out the deserialized students
            foreach (var student in deserializedStudentsJson)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Course: {student.Course}");
            }


            // Specify the path for the XML file
            string filePathXml = "students.xml";

            // Serialize the list of students to a file
            serialization.SerializeToXML(students, filePathXml);
            Console.WriteLine("Students serialized to file successfully.");

            // Deserialize the list of students from the XML file
            List<Student> deserializedStudentsXml = serialization.DeserializeFromXML(filePathXml);
            Console.WriteLine("Students deserialized from XML file successfully.");

            // Print out the deserialized students from XML
            Console.WriteLine("Deserialized Students from XML:");
           foreach (var student in deserializedStudentsXml)
           {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Course: {student.Course}");
           }
        }

    }
    
}

           