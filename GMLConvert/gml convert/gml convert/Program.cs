using gml_convert;
using System.Xml;
using System.Xml.Linq;
class Program
{

    static void Main(string[] args)
    {
        string coords = "";
        bool isNumber = false;
        getFeatures getFeatures = new getFeatures();
        converter converter = new converter();
        string filePath = "C:\\Users\\nijme\\Desktop\\OpdrachtenStage\\GMLConvert\\datafiles\\";
        XNamespace GMLNamespace = "http://www.opengis.net/gml/3.2";
        XDocument xdoc = converter.GetFromXmlFile(filePath);
        var points = xdoc.Descendants(GMLNamespace + "featureMember").Descendants(GMLNamespace + "Point").Select(p => p.Descendants(GMLNamespace + "pos")).ToList();
        var Lines = xdoc.Descendants(GMLNamespace + "featureMember").Descendants(GMLNamespace + "LineString").Select(p => p.Descendants(GMLNamespace + "posList")).ToList();
        Console.WriteLine("[1] Lines\n[2] Points");
        int keuze = Convert.ToInt32(Console.ReadLine());
        switch (keuze) { 
            case 1:
                coords = getFeatures.GetLineCoords(GMLNamespace, xdoc);
                Console.WriteLine(coords);
                break;
            case 2:
                coords = getFeatures.GetPointCoords(GMLNamespace, xdoc);
                Console.WriteLine(coords);
                break;
            
        }
        
       

        
    }
}