using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace gml_convert
{
    public class getFeatures
    {
        public string GetPointCoords(XNamespace GMLNamespace, XDocument xdoc)
        {
            string coords = "";
            var points = xdoc.Descendants(GMLNamespace + "featureMember").Descendants(GMLNamespace + "Point").Select(p => p.Descendants(GMLNamespace + "pos")).ToList();
            foreach (var point in points)
            {
                foreach (string pos in point)
                {
                    coords = coords + "\n";
                    foreach (char letter in pos)
                    {
                        try
                        {
                            char letter2 = letter;
                            Convert.ToInt32(letter);
                            coords = coords + letter2;
                        }
                        catch
                        {
                            continue;
                        }


                    }
                }

            }
            return coords;

        }
        public string GetLineCoords(XNamespace GMLNamespace, XDocument xdoc)
        {
            string coords = "";
            var Lines = xdoc.Descendants(GMLNamespace + "featureMember").Descendants(GMLNamespace + "LineString").Select(p => p.Descendants(GMLNamespace + "posList")).ToList();
            foreach (var line in Lines)
            {
                foreach (string posList in line)
                {
                    coords = coords + "\n";
                    foreach (char letter in posList)
                    {
                        try
                        {
                            char letter2 = letter;
                            Convert.ToInt32(letter);
                            coords = coords + letter2;
                        }
                        catch
                        {
                            continue;
                        }


                    }
                }

            }
            return coords;

        }
    }
}
