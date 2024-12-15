using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
namespace gml_convert
{
    public class converter
    {
        
            public XDocument GetFromXmlFile(string path)
            {
                Console.WriteLine("File name? (Including extension)");
                string fileNameLoad = Console.ReadLine();
                string loadFile = path + fileNameLoad;

                
            return XDocument.Load(loadFile);
            }
        
        }
}
