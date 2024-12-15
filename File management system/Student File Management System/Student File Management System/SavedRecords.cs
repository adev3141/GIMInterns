using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_File_Management_System
{
     class SavedRecords
    {
        List<string> jsonRecords = new List<string>();
        List<string> xmlRecords = new List<string>();


        public List<string> JsonRecords { get => jsonRecords; set => jsonRecords = value; }
        public List<string> XmlRecords { get => xmlRecords; set => xmlRecords = value; }
    }
}
