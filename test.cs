using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class Tests
    {
        public void writeCoords(double[] x, double[] y, double[] xPoint, double[] yPoint, List<string> coordsThings)
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


    }
}
