using System;
using System.Xml.Linq;

namespace MyConverterNamespace
{
    // Class responsible for converting and loading XML files.
    internal class ConverterClass
    {
        // Method to load an XML file and return its XDocument representation.
        public XDocument GetFromXmlFile(string Path)
        {
            // Prompt the user to enter the file name (including extension).
            Console.WriteLine("File name? (Including extension)");
            string FileName = Console.ReadLine(); // Read the file name input from the user.

            // Combine the provided path with the file name to create the full file path.
            string LoadFile = Path + FileName;

            // Load the XML document from the specified file path and return it.
            return XDocument.Load(LoadFile);
        }
    }   
}
