using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyConverterNamespace
{
    class gmlCoordinate
    {
        public class getFeatures
        {//XNamespace makes sure that it correctly identifies the element namespace,  XDocument the document where the method will exract point coordinates   
            public string GetPointCoordinates(XNamespace GmlNamespace, XDocument xDocument)
            {//StringBuilder to efficiently build the string of coordinates.
                StringBuilder Coordinates = new StringBuilder();

                // Extract all <pos> elements within <Point> elements inside <featureMember> elements.
                var Points = xDocument.Descendants(GmlNamespace + "featureMember")// Get all <featureMember> elements.
                                      .Descendants(GmlNamespace + "Point") // Within those, get all <Point> elements.
                                      .Select(Point => Point.Descendants(GmlNamespace + "pos")) // For each <Point>, get the <pos> elements.
                                      .ToList();// Convert the result to a list.

                foreach (var Point in Points)//loops over each collection of pos elements 
                {
                    foreach (var pos in Point)//loops over each pos element within the current point
                    {
                        //sets the text content of pos element (the coordinates) in the stringbuilder.AppendLine adds text followed by a newline
                        Coordinates.AppendLine(pos.Value);
                    }
                }
                return Coordinates.ToString();//converts the stringbuilder to sting and returns it
            }

            public string GetLineCoordinates(XNamespace GmlNamespace, XDocument xDocument)
            {//StringBuilder to efficiently build the string of coordinates.
                StringBuilder Coordinates = new StringBuilder();

                // Extract all <LineString> elements within <Point> elements inside <featureMember> elements.
                var Lines = xDocument.Descendants(GmlNamespace + "featureMember")// Get all <featureMember> elements.
                                     .Descendants(GmlNamespace + "LineString")// Within those, get all <Point> elements.
                                     .Select(line => line.Descendants(GmlNamespace + "posList")) // For each <Point>, get the <pos> elements.
                                     .ToList();// Convert the result to a list.

                foreach (var Line in Lines)//loops over each collection of poslist elements 
                {
                    foreach (var PosList in Line)//loops over each pos element within the current Line
                    {
                        //sets the text content of poslist element (the coordinates) in the stringbuilder.AppendLine adds text followed by a newline
                        Coordinates.AppendLine(PosList.Value);
                    }
                }

                return Coordinates.ToString();//converts the stringbuilder to sting and returns it
            }
        }
    }
}
