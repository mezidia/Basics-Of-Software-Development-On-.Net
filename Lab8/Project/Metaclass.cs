// Licensed to the Mezidia Foundation under one or more agreements.
// The Mezidia Foundation licenses this file to you under the MIT license.

using System;

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
