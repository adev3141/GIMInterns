using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Student_File_Management_System
{
     class ToXml
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
    }
}
