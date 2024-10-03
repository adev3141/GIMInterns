using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using MyConverterNamespace;



namespace MyConverterNamespace
{
    class MainWindow
    {
       
        static void Main(string[] args)
        {
            // Instantiate the feature and converter classes
            GetFeatures getFeatures = new GetFeatures();
            ConverterClass converter = new ConverterClass();
            bool Running = true;


            // file path for GML files;            
            Console.WriteLine("Put in the file path to find the gml file");
            string filePath = Console.ReadLine();
            
            // Define the GML namespace to correctly interpret XML elements
            XNamespace gmlNamespace = "http://www.opengis.net/gml/3.2";

            // Load the XML document from the specified file path
            XDocument xDocument = converter.GetFromXmlFile(filePath);

           

            while (Running)
            {
                Console.WriteLine("1. see points");
                Console.WriteLine("2. see lines");
                Console.WriteLine("3. to exit");

                string Input = Console.ReadLine();

                switch(Input)
                {//does not come here
                    case "1":
                        // Extract and display point coordinates
                        string pointCoordinates = getFeatures.GetPointCoordinates(gmlNamespace, xDocument);
                        Console.WriteLine("Point Coordinates:\n" + pointCoordinates);
                        break;
                    case "2":
                        // Extract and display line coordinates
                        string lineCoordinates = getFeatures.GetLineCoordinates(gmlNamespace, xDocument);
                        Console.WriteLine("Line Coordinates:\n" + lineCoordinates);// an proceed to call methods from getFeatures or work with xDocument
                        break;
                    case "3":
                        Running = false;
                        break;

                }
            }

        }
    }
}
