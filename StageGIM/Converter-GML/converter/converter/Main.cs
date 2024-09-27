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
           // string StringCoordinates = "";
           

            // Hard-coded file path for GML files; prompting the user for input in the future
            string filePath = "C:\\Users\\ruvey\\OneDrive - ROC Nijmegen\\school\\Webapplicatie\\webapp2\\GIMInterns\\gml-files";

            // Define the GML namespace to correctly interpret XML elements
            XNamespace gmlNamespace = "http://www.opengis.net/gml/3.2";

            // Load the XML document from the specified file path
            XDocument xDocument = converter.GetFromXmlFile(filePath);

            // Extract and display point coordinates
            string pointCoordinates = getFeatures.GetPointCoordinates(gmlNamespace, xDocument);
            Console.WriteLine("Point Coordinates:\n" + pointCoordinates);

            // Extract and display line coordinates
            string lineCoordinates = getFeatures.GetLineCoordinates(gmlNamespace, xDocument);
            Console.WriteLine("Line Coordinates:\n" + lineCoordinates);// an proceed to call methods from getFeatures or work with xDocument


        }
    }
}
