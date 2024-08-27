using System;
using System.Xml.Linq;
using System.Linq;

string gmlFilePath = "C:\\Users\\ruvey\\Downloads\\xml\\test.xml";

List<double> XCoords = new List<double>();
List<double> YCoords = new List<double>();
XDocument gmlDocument = XDocument.Load(gmlFilePath);
XNamespace gmlNamespace = "http://www.opengis.net/gml";
int counter = 0;

foreach (var feature in gmlDocument.Descendants(gmlNamespace + "posList"))
{
    string strFeature = feature.Value; // Get the inner text value of the <posList> element
    string[] coordinates = strFeature.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

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

foreach (var x in XCoords)
{
    Console.WriteLine($"X: {x}");
}
foreach (var y in YCoords)
{
    Console.WriteLine($"Y: {y}");
}