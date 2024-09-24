using System.Text.Json;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.Diagnostics;


namespace Student_File_Management_System
{
     class fileConverter
    {
        public string SerializeToXml<T>(T obj)
        {
            // Initialize an XmlSerializer with the type of the object to serialize
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            // Use a StringWriter to hold the serialized XML
            using (StringWriter stringWriter = new StringWriter())
            {
                // Serialize the object to the StringWriter
                serializer.Serialize(stringWriter, obj);

                // Return the XML as a string
                return stringWriter.ToString();
            }
        }
        public string SerializeToJson(string path2, Student i)
        {
            string jsonString = "";
            using (StreamWriter sw = new StreamWriter(path2)) {
                 jsonString = JsonSerializer.Serialize(i);
                Console.WriteLine(jsonString);
                sw.WriteLine(jsonString);
            }
            return jsonString;
            
                                    }
}
}
