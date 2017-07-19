using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Creating_XML_Doc
{
    public static class Employee
    {
        static XDocument xDcumment { get; set; }
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
            xDcumment.Save(@"C:\Users\User\Desktop\CSharpDemos\Creating XML Doc\Creating XML Doc\Data.xml");
        }
    }    
} 
 