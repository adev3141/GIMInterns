using System.Windows;
using System;
using testing;
using static testing.Coordinates;

public class Program
{
    static void Main(string[] args)
    {
        // Define the path to the XML file
        string gmlFilePath = "C:\\Users\\ruvey\\Downloads\\xml\\test.xml";

        // Create an instance of AllCoordinates
        var coordinates = new AllCoordinates(); // Instantiate the class

        // Call the DivideCoordinates method to process the XML file
        coordinates.DivideCoordinates(gmlFilePath);

        // Output the X and Y coordinates
        Console.WriteLine("X Coordinates:");

        foreach (var x in coordinates.GetXCoords())
        {
            Console.WriteLine(x);
        }

        Console.WriteLine("\nY Coordinates:");

        foreach (var y in coordinates.GetYCoords())
        {
            Console.WriteLine(y);
        }

    }
}

