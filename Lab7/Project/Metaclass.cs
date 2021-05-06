using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Project
{
    public class Metaclass : Exception
    {
        public void MetaMethod()
        {
            Console.WriteLine("Метархия запрещена.");
        }
    }
}
