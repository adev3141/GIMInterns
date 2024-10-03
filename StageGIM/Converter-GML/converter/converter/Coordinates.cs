using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using MyConverterNamespace;

namespace MyConverterNamespace
{
    // Class for handling GML coordinate extraction.

    public class GetFeatures
    {

        // Method to extract coordinates from <Point> elements in a GML document.
        public string GetPointCoordinates(XNamespace gmlNamespace, XDocument xDocument)
        {
            // StringBuilder to build the string of coordinates.
            StringBuilder coordinates = new StringBuilder();

            // Extract all <pos> elements within <Point> elements inside <featureMember> elements.
            var points = xDocument.Descendants(gmlNamespace + "featureMember") // Get all <featureMember> elements.
                                  .Descendants(gmlNamespace + "Point") // Within those, get all <Point> elements.
                                  .Select(point => point.Descendants(gmlNamespace + "pos")) // For each <Point>, get the <pos> elements.
                                  .ToList(); // Convert the result to a list.

            // Loop over each collection of <pos> elements for the points.
            foreach (var point in points)
            {
                // Loop over each <pos> element within the current point.
                foreach (var Posistion in point)
                {
                    // Append the text content of the <pos> element to the StringBuilder.
                    coordinates.AppendLine(Posistion.Value);
                }
            }

            // Convert the StringBuilder to a string and return it.
            return coordinates.ToString();
        }

        // Method to extract coordinates from <LineString> elements in a GML document.
        public string GetLineCoordinates(XNamespace gmlNamespace, XDocument xDocument)
        {
            // StringBuilder to efficiently build the string of coordinates.
            StringBuilder coordinates = new StringBuilder();

            // Extract all <posList> elements within <LineString> elements inside <featureMember> elements.
            var lines = xDocument.Descendants(gmlNamespace + "featureMember") // Get all <featureMember> elements.
                                 .Descendants(gmlNamespace + "LineString") // Within those, get all <LineString> elements.
                                 .Select(line => line.Descendants(gmlNamespace + "posList")) // For each <LineString>, get the <posList> elements.
                                 .ToList(); // Convert the result to a list.

            // Loop over each collection of <posList> elements for the lines.
            foreach (var line in lines)
            {
                // Loop over each <posList> element within the current line.
                foreach (var CoordinateList in line)
                {
                    // Append the text content of the <posList> element (the coordinates) to the StringBuilder.
                    coordinates.AppendLine(CoordinateList.Value);
                }
            }

            // Convert the StringBuilder to a string and return it.
            return coordinates.ToString();


        }
    }
}
