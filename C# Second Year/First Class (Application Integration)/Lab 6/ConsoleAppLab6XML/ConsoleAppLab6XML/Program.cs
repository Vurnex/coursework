using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml.XPath;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.Linq;

namespace ConsoleAppLab6XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Transform XML to HTML
            Console.WriteLine("Transforming...");

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(@"C:\Users\Laquon\Documents\Homework\ITS-462\Lab 6\drones.xslt");
            xslt.Transform(@"C:\Users\Laquon\Documents\Homework\ITS-462\Lab 6\lab6.xml", 
                @"C:\Users\Laquon\Documents\Homework\ITS-462\Lab 6\lab6-output.html");

            Console.Write("Done.");

            //Convert XML element names

            XDocument xdoc = XDocument.Load(@"C:\Users\Laquon\Documents\Homework\ITS-462\Lab 6\lab6.xml");

            foreach (var element in xdoc.Descendants())
            {
                if (element.Name.LocalName.StartsWith("table"))
                {
                    element.Name = "data";
                }

                if (element.Name.LocalName.StartsWith("trow"))
                {
                    element.Name = "info";
                }

                if (element.Name.LocalName.StartsWith("Manufacturer"))
                {
                    element.Name = "creator";
                }

                if (element.Name.LocalName.StartsWith("Model"))
                {
                    element.Name = "version";
                }

                if (element.Name.LocalName.StartsWith("Price"))
                {
                    element.Name = "cost";
                }

                if (element.Name.LocalName.StartsWith("Time"))
                {
                    element.Name = "range";
                }

                if (element.Name.LocalName.StartsWith("Size"))
                {
                    element.Name = "proportion";
                }
            }

            xdoc.Save(@"C:\Users\Laquon\Documents\Homework\ITS-462\Lab 6\lab6-rename.xml");
        }
    }
}
