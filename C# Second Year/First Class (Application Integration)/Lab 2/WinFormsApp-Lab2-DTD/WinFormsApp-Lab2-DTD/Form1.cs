using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;           // needed for this code snippet
using System.Xml.Schema;    // needed for this code snippet

namespace WinFormsApp_Lab2_DTD
{
    public partial class validationForm : Form
    {
        public validationForm()
        {
            InitializeComponent();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            validatingXMLWithDTD(@"C:\Users\Laquon\Documents\Homework\ITS-462\Lab 2\lab2.xml");
        }

        private void validatingXMLWithDTD(string fileFullPath)
        {
            // Set the validation settings.  Specifies a set of features to 
            // support on the XmlReader object created by the Create method.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ProhibitDtd = false;
            settings.ValidationType = ValidationType.DTD;
            settings.XmlResolver = new XmlUrlResolver();

            // Validation error and warning messages are handled using the 
            // ValidationEventHandler delegate. Captures errors and warnings
            // when validating an XML document against a DTD.
            // Calls method ValidationCallBack defined below.
            settings.ValidationEventHandler +=
                new ValidationEventHandler(ValidationCallBack);

            txtMessage.Text = "Retrieving DTD - Please wait...\r\n";
            txtMessage.Update();

            // Create the XmlReader object.
            XmlReader reader = XmlReader.Create(fileFullPath, settings);

            txtMessage.Text += "Starting parsing...\r\n";
            // validate the file while reading/parsing... 
            while (reader.Read())
            {
                if (reader.IsStartElement())  // Tests if the current content node is a start tag.
                    txtMessage.Text += reader.LocalName + " START\r\n";
            };
            txtMessage.Text += "End parsing...\r\n";
        }

        // Display any validation errors.
        private void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
                txtMessage.Text +=
                    "Warning: Matching schema not found.  No validation occurred."
                    + e.Message + "\r\n";
            else
                txtMessage.Text += "Validation Error: " + e.Message + "\r\n";
        }

    }
}
