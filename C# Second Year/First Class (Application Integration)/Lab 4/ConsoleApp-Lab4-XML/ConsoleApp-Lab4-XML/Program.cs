using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp_Lab4_XML
{
    class Program
    {
        static void Main(string[] args)
        {

            //Use LINQ library to load in and append nodes
            var xdoc = XDocument.Load(@"C:\Users\Laquon\Documents\Homework\ITS-462\Lab 4\lab4.xml");

            var separator = new XElement("NewElements",
                new XElement("NewElementsAfter", "" +
                "--------")); //indicate that new elements have been appended

            var newElement1 = new XElement("trow",
                    new XElement("Manufacturer", "Hobby King"),
                    new XElement("Model", "Quanum Nova"),
                    new XElement("Price", "400"),
                    new XElement("Time", "8 to 11"),
                    new XElement("Size", "Medium"));

            var newElement2 = new XElement("trow",
                    new XElement("Manufacturer", "Traxxas"),
                    new XElement("Model", "LaTrax Alias"),
                    new XElement("Price", "150"),
                    new XElement("Time", "5 to 7"),
                    new XElement("Size", "Small"));

            var newElement3 = new XElement("trow",
                    new XElement("Manufacturer", "Parrot"),
                    new XElement("Model", "AR Drone 2.0"),
                    new XElement("Price", "299"),
                    new XElement("Time", "9 to 12"),
                    new XElement("Size", "Medium"));

            var newElement4 = new XElement("trow",
                    new XElement("Manufacturer", "Lumenier"),
                    new XElement("Model", "QAV 400 RTF"),
                    new XElement("Price", "970"),
                    new XElement("Time", "8 to 12"),
                    new XElement("Size", "Medium"));

            var newElement5 = new XElement("trow",
                    new XElement("Manufacturer", "Hobbico"),
                    new XElement("Model", "Proto X"),
                    new XElement("Price", "38"),
                    new XElement("Time", "5 to 6"),
                    new XElement("Size", "Crazy Small"));

            xdoc.Element("table").Add(separator, newElement1, newElement2, 
                newElement3, newElement4, newElement5);

            xdoc.Save(@"C:\Users\Laquon\Documents\Homework\ITS-462\Lab 4\lab4.xml");

        }
    }
}
