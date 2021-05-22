using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingLibrary
{
    public interface IErrorHandler
    {
        void Handle(Exception exception);
    }
}
