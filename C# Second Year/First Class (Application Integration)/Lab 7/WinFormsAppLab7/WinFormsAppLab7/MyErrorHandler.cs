using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MSXML2;

namespace WinFormsAppLab7
{
    class MyErrorHandler : MSXML2.IVBSAXErrorHandler
    {
        frmSAX myForm;

        public MyErrorHandler(frmSAX saxForm)
        {
            myForm = saxForm;
        }

        void IVBSAXErrorHandler.error(IVBSAXLocator oLocator, ref string strErrorMessage, int nErrorCode)
        {
            //throw new NotImplementedException();
            throw new ApplicationException("Error: " + strErrorMessage);
        }

        void IVBSAXErrorHandler.fatalError(IVBSAXLocator oLocator, ref string strErrorMessage, int nErrorCode)
        {
            //throw new NotImplementedException();
            throw new ApplicationException("Fatal Error: " + strErrorMessage);
        }

        void IVBSAXErrorHandler.ignorableWarning(IVBSAXLocator oLocator, ref string strErrorMessage, int nErrorCode)
        {
            //throw new NotImplementedException();
            throw new ApplicationException("Warning: " + strErrorMessage);
        }
    }
}
