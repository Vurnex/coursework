using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSXML2;

namespace WinFormsAppLab7
{
    public partial class frmSAX : Form
    {
        string xmlURL = @"C:\Users\Laquon\Documents\Homework\ITS-462\Lab 7\lab7.xml";

        public frmSAX()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            // declare objects of SAXXMLReader, MyContentHandler, and MyErrorHandler
            SAXXMLReader reader = new SAXXMLReader();
            MyContentHandler contentHandler = new MyContentHandler(this);
            MyErrorHandler errorHandler = new MyErrorHandler(this);

            txtOutput.Clear();
            reader.contentHandler = contentHandler;  // assign contentHandler object to contentHandler property
            reader.errorHandler = errorHandler;  // assign errorHandler object to errorHandler property


            try
            {
                reader.parseURL(xmlURL); //parse/process the xml doc located at xmlURL
            }
            catch (Exception ex)
            {
                OutputText += ex.Message;
            }
        }

        // OutputText property
        public string OutputText
        {
            get { return txtOutput.Text; }
            set { txtOutput.Text += value; } // += is important!
        }

        private void frmSAX_Load(object sender, EventArgs e)
        {

        }
    }
}

