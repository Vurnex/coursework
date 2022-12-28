using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MSXML2;

namespace WinFormsAppLab7
{
    class MyContentHandler : MSXML2.IVBSAXContentHandler
    {
        const string CRLF = "\r\n";
        frmSAX myForm;
        string thisText;

        // non-default constructor
        public MyContentHandler(frmSAX saxForm)
        {
            this.myForm = saxForm;
        }

        internal void characters(string strChars)
        {
            throw new NotImplementedException();
        }

        // === display the content of thisText ===
        public void displayText()
        {
            myForm.OutputText = "   Text: [" + thisText + "]" + CRLF;
            thisText = null;
            
        }

        void IVBSAXContentHandler.characters(ref string strChars)
        {
            if (strChars.Length > 0)
            {
                //strChars = strChars.Replace("\n", CRLF);
                thisText += strChars;
            }

        }

        IVBSAXLocator IVBSAXContentHandler.documentLocator
        {
            set {; }
        }

        void IVBSAXContentHandler.endDocument()
        {
            myForm.OutputText = CRLF + "Document END.";
            //outputResults();
        } 

        void IVBSAXContentHandler.endElement(ref string strNamespaceURI, ref string strLocalName, ref string strQName)
        {
            

            //thisText = null;
        }

        void IVBSAXContentHandler.endPrefixMapping(ref string strPrefix)
        {
            //throw new NotImplementedException();
        }

        void IVBSAXContentHandler.ignorableWhitespace(ref string strChars)
        {
            //throw new NotImplementedException();
        }

        void IVBSAXContentHandler.processingInstruction(ref string strTarget, ref string strData)
        {
            //throw new NotImplementedException();
        }

        void IVBSAXContentHandler.skippedEntity(ref string strName)
        {
            //throw new NotImplementedException();
        }

        void IVBSAXContentHandler.startDocument()
        {
            myForm.OutputText = "Document START" + CRLF;
        }

        void IVBSAXContentHandler.startElement(ref string strNamespaceURI, ref string strLocalName, 
            ref string strQName, IVBSAXAttributes oAttributes)
        {
            
            if (strLocalName.Equals("trow"))
            {
                //myForm.OutputText = "Element found." + CRLF;
                myForm.OutputText = thisText;
                thisText = null;
            }

            //thisText = null;

        }

        void IVBSAXContentHandler.startPrefixMapping(ref string strPrefix, ref string strURI)
        {
            //throw new NotImplementedException();
        }
    }
}
