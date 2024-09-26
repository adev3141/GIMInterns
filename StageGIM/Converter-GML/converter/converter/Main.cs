using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static MyConverterNamespace.converterClass;

namespace MyConverterNamespace
{
    class MainWindow
    {

        static void Main(string[] args)
        {
            getFeatures getFeatures = new getFeatures();
            converter Converter = new converter();
            string FilePath = "C:\\Users\\ruvey\\OneDrive - ROC Nijmegen\\school\\Webapplicatie\\webapp2\\GIMInterns\\gml-files";  //this is hard coded later make it so it is userinput? it has the gml file to read
            XNamespace GmlNameSpace = "http://www.opengis.net/gml/3.2"; //makes it so that it can have gml
            XDocument XDocumets = null;  // has to have a different value!!!
        }
              public class getFeatures
        {

        }

        public class converter
        {

        }

    }
}

