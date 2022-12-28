using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MSXML2;

namespace WinFormsAppLab7
{
    class MyFilter : IVBSAXXMLReader, IVBSAXXMLFilter
    {
        private MSXML2.SAXXMLReader parentReader;
        private MyContentHandler cHandler;
        private frmSAX myForm;

        public void endDocument()
        {
            throw new NotImplementedException();
        }

        public void endElement(ref string strNamespaceURI, ref string strLocalName, ref string strQName)
        {
            throw new NotImplementedException();
        }

        public void endPrefixMapping(ref string strPrefix)
        {
            throw new NotImplementedException();
        }

        public void ignorableWhitespace(ref string strChars)
        {
            throw new NotImplementedException();
        }

        public void processingInstruction(ref string strTarget, ref string strData)
        {
            throw new NotImplementedException();
        }

        public void skippedEntity(ref string strName)
        {
            throw new NotImplementedException();
        }

        public void startDocument()
        {
            throw new NotImplementedException();
        }

        public void startElement(ref string strNamespaceURI, ref string strLocalName, ref string strQName, MSXML2.IVBSAXAttributes oAttributes)
        {
            throw new NotImplementedException();
        }

        public void startPrefixMapping(ref string strPrefix, ref string strURI)
        {
            throw new NotImplementedException();
        }

        public string baseURL
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public MSXML2.IVBSAXContentHandler contentHandler
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public MSXML2.IVBSAXDTDHandler dtdHandler
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public MSXML2.IVBSAXEntityResolver entityResolver
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public MSXML2.IVBSAXErrorHandler errorHandler
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool getFeature(string strName)
        {
            throw new NotImplementedException();
        }

        public dynamic getProperty(string strName)
        {
            throw new NotImplementedException();
        }

        public void parse([System.Runtime.InteropServices.OptionalAttribute] object varInput)
        {
            throw new NotImplementedException();
        }

        public void parseURL(string strURL)
        {
            throw new NotImplementedException();
        }

        public void putFeature(string strName, bool fValue)
        {
            throw new NotImplementedException();
        }

        public void putProperty(string strName, object varValue)
        {
            throw new NotImplementedException();
        }

        public string secureBaseURL
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public MSXML2.IVBSAXXMLReader parent
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
