using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic; // Required for List<T>
using System.Xml.Linq; // Required for working with XML
using System.Linq; // Required for LINQ

namespace testing
{
    internal class Coordinates
    {
        public class AllCoordinates
        {
            string info = "posList";
            // field to store X and Y coordinates 
            private List<double> XCoords = new List<double>();
            private List<double> YCoords = new List<double>();

            // Method to divide coordinates from the XML file
            public void DivideCoordinates(string gmlFilePath)
            {

                // Load the XML document
                XDocument gmlDocument = XDocument.Load(gmlFilePath);  // Corrected usage of gmlFilePath
                XNamespace gmlNamespace = "http://www.opengis.net/gml";  // Assuming this is the correct namespace
                int counter = 0;


                foreach (var feature in gmlDocument.Descendants(gmlNamespace + info))
                {
                    string strFeature = feature.Value; // Get the inner text value of the <posList> element
                    string[] coordinates = strFeature.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries); //split the coordinates in 4 and remove emty space

                    foreach (string coord in coordinates)
                    {
                        if (double.TryParse(coord, out double parsedCoord))
                        {
                            if (counter % 2 == 0)
                            {
                                XCoords.Add(parsedCoord);
                            }
                            else
                            {
                                YCoords.Add(parsedCoord);
                            }
                            counter++;
                        }
                    }
                }
            }

            //method to get the X coordinates
            public List<double> GetXCoords()
            {
                return XCoords;
            }

            //method to get the Y coordinates
            public List<double> GetYCoords()
            {
                return YCoords;
            }
        }
    }
}
