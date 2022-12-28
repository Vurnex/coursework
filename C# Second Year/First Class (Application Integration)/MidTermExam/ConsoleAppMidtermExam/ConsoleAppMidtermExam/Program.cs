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

namespace ConsoleAppMidtermExam
{
    class Program
    {
        static void Main(string[] args)
        {

            //Transform XML to HTML
            Console.WriteLine("Transforming...");

            XslCompiledTransform xslt = new XslCompiledTransform();

            xslt.Load(@"C:\Users\Laquon\Documents\Homework\ITS-462\MidTermExam\students.xslt");

            xslt.Transform(@"C:\Users\Laquon\Documents\Homework\ITS-462\MidTermExam\midterm.xml",
                @"C:\Users\Laquon\Documents\Homework\ITS-462\MidTermExam\midterm-output.html");

            Console.Write("Done.");

            //Convert XML element names

            XDocument xdoc = XDocument.Load(@"C:\Users\Laquon\Documents\Homework\ITS-462\MidTermExam\midterm.xml");

            foreach (var element in xdoc.Descendants())
            {
                if (element.Name.LocalName.StartsWith("Students"))
                {
                    element.Name = "Teacher";
                }

                if (element.Name.LocalName.StartsWith("Hw1"))
                {
                    element.Name = "Lab1";
                }

                if (element.Name.LocalName.StartsWith("Hw2"))
                {
                    element.Name = "Lab2";
                }

                if (element.Name.LocalName.StartsWith("Hw3"))
                {
                    element.Name = "Lab3";
                }

            }

            xdoc.Save(@"C:\Users\Laquon\Documents\Homework\ITS-462\MidTermExam\midterm-rename.xml");

        }
    }
}
