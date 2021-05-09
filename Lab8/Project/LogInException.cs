using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Project
{
    public class LogInException : Exception
    {
        public LogInException(string message)
           : base(message)
        {

        }
    }
}
