using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyConverterNamespace
{
    internal class converterClass
    {
        public XDocument GetFromXmlFile(string Path)
        {
            Console.WriteLine("File name? (Including extension)");
            string FileNameLoad = Console.ReadLine();
            string LoadFile = Path + FileNameLoad;


            return XDocument.Load(LoadFile);
        }

      
    }



}

