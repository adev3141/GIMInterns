using System;
using System.Xml.Linq;
using System.Collections.Generic;
using XML;

class XMLFiles
{
    static void Main(string[] args)
    {
        Console.WriteLine("File path?");
        string? gmlFilePath = Console.ReadLine();
        gmlFilePath = "C:\\Users\\nijme\\Downloads\\XLM\\XMLNote.xml"; // Hardcoded for demonstration
        int keuze2 = 0;
        string? keuze = "";
        List<string> coordtypes = new List<string>();
        List<double> XCoords = new List<double>();
        List<double> YCoords = new List<double>();
        List<double> XCoordsPoint = new List<double>();
        List<double> YCoordsPoint = new List<double>();
        Tests test = new Tests();
        Console.WriteLine("How many different things would you like to know the coords of?");
        int coordAmount = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i < coordAmount; i++)
        {
            Console.WriteLine("Name of what you'd like the coord of? (For example, Point or LineString)");
            keuze = Console.ReadLine();
        
            
                if (coordtypes.Count > 0 && keuze == coordtypes[coordtypes.Count - 1])
                {
                    Console.WriteLine("Al gekozen.\n[1] Opnieuw kiezen\n[2] Toch verdergaan");
                    keuze2 = Convert.ToInt16(Console.ReadLine());

                    if (keuze2 == 1)
                    {
                        // Reset i to -1, but we will increment in the for loop anyway, so it goes back to 0.
                        i = -1;
                        coordtypes.Clear(); // Clear the list to start fresh as per your logic.
                    }
                }
                else
                {
                    coordtypes.Add(keuze);
                }
            }
        

        XDocument gmlDocument = XDocument.Load(gmlFilePath);
        XNamespace gmlNamespace = "http://www.opengis.net/gml";

        // Loop over each coordtype entered by the user
        foreach (string coordType in coordtypes)
        {
            foreach (var feature in gmlDocument.Descendants(gmlNamespace + coordType))
            {
                string strFeature = feature.Value;
                string[] coordinates = strFeature.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                int counter = 0; // Counter to determine if the coordinate is X or Y

                foreach (string coord in coordinates)
                {
                    if (double.TryParse(coord, out double parsedCoord))
                    {
                        if (counter % 2 == 0) // Even index -> X coordinate
                        {
                            if (coordType == "LineString")
                            {
                                XCoords.Add(parsedCoord);
                            }
                            else if (coordType == "Point")
                            {
                                XCoordsPoint.Add(parsedCoord);
                            }
                        }
                        else // Odd index -> Y coordinate
                        {
                            if (coordType == "LineString")
                            {
                                YCoords.Add(parsedCoord);
                            }
                            else if (coordType == "Point")
                            {
                                YCoordsPoint.Add(parsedCoord);
                            }
                        }
                        counter++;
                    }
                }
            }
        }

        // Pass the lists to writeCoords function
        test.writeCoords(XCoords.ToArray(), YCoords.ToArray(), XCoordsPoint.ToArray(), YCoordsPoint.ToArray(), coordtypes);
    }

    private void writeCoords(double[] x, double[] y, double[] xPoint, double[] yPoint, List<string> coordsThings)
    {
        for (int i = 0; i < coordsThings.Count; i++)
        {
            string coord = coordsThings[i];
            if (coord == "LineString")
            {
                Console.WriteLine($"{coord} at:");
                for (int j = 0; j < x.Length; j++)
                {
                    Console.WriteLine($"X: {x[j]}, Y: {y[j]}");
                }
            }
            else if (coord == "Point")
            {
                Console.WriteLine($"{coord} at:");
                for (int j = 0; j < xPoint.Length; j++)
                {
                    Console.WriteLine($"X: {xPoint[j]}, Y: {yPoint[j]}");
                }
            }
        }
    }

    private static (List<double> xCoords, List<double> yCoords) addCoordsList(string coordsType)
    {
        List<double> xCoords = new List<double>();
        List<double> yCoords = new List<double>();
        return (xCoords, yCoords);
    }

    private static List<string> coordType(string coord, List<string> coordTypeArray)
    {
        coordTypeArray.Add(coord);
        return coordTypeArray;
    }
}
