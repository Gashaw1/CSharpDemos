using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Createing_and_reading_xml_Dcument
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee.CreateXml();
            Employee.ReadEmpXMLDocument();
            Console.Read();
        }
    }
}
