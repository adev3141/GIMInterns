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
    internal class Serialization
    {
        public void SerializeToFile(List<Student> Students, string FilePath)
        {
            //string will hold the JSON-formatted string representation. converts students into JSONstring
            string JsonString = JsonSerializer.Serialize(Students, new JsonSerializerOptions { WriteIndented = true });//last part makes it pretty
            File.WriteAllText(FilePath, JsonString);// It either creates a new file if it doesn’t exist or overwrites the file if it already exists
        }

        public List<Student> DeserializeFromFile(string FilePath)
        {
            // Read the JSON content from the file
            string JsonString = File.ReadAllText(FilePath);

            // Deserialize the JSON string to a list of Student objects
            List<Student> Students = JsonSerializer.Deserialize<List<Student>>(JsonString);

            return Students;
        }

        public void SerializeToXML(List<Student> Students, string FilePath)
        {
            // Create an XmlSerializer instance, specifying the type of object to serialize.
            var serializer = new XmlSerializer(typeof(List<Student>));

            // Use the StreamWriter to write the serialized XML data to the file at the given FilePath.
            //Using make sure that StreamWriter is closed and disposed of after use.
            using (var writer = new StreamWriter(FilePath))
            {
                // Serialize the 'Students' list into XML format and write it to the file.
                serializer.Serialize(writer, Students);
            }
        }


        // Method to deserialize a list of students from an XML file
        public List<Student> DeserializeFromXML(string filePath)
        {
            // Create an XmlSerializer instance, specifying the type of object to deserialize.
            var serializer = new XmlSerializer(typeof(List<Student>));

            // Use the StreamReader to read the XML data from the specified file.
            //Using make sure that StreamWriter is closed and disposed of after use.
            using (var reader = new StreamReader(filePath))
            {
                // The Deserialize method converts the XML data back into a List<Student> object.
                return (List<Student>)serializer.Deserialize(reader);
            }
        }
    }

}
