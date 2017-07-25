using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Createing_and_reading_xml_Dcument
{
    public static class Employee
    {
        static XDocument xDcumment;
         
        public static void CreateXml()
        {
            xDcumment = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Eemployee File"),
                new XElement("Employees",
                new XElement("employee", new XAttribute("ID", 1000),
                new XElement("Name", "Akal"),
                new XElement("Gender", "Male"),
                new XElement("Salery", "100000000")),
                new XElement("employee", new XAttribute("ID", 1000),
                new XElement("Name", "Mena"),
                new XElement("Gender", "Female"),
                new XElement("Salery", "1000000")),
                 new XElement("employee", new XAttribute("ID", 1000),
                new XElement("Name", "Hana"),
                new XElement("Gender", "Female"),
                new XElement("Salery", "1000000"))

                ));
            xDcumment.Save(@"C:\Users\User\Desktop\CSharpDemos\Createing and reading xml Dcument\Createing and reading xml Dcument\Data.xml");
        }
        //from created xml doc
        public static void ReadEmpXMLDocument()
        {            

            IEnumerable<string> Emps = from Emp in XDocument.Load(@"C:\Users\User\Desktop\CSharpDemos\Createing and reading xml Dcument\Createing and reading xml Dcument\Data.xml")
                                       .Descendants("employee")                                                                           
                                       select Emp.Element("Name").Value;

            foreach (string v in Emps)
            {
                Console.WriteLine(v);

            }            
        }
    }
}
