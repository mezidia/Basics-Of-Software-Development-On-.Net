﻿// Licensed to the Mezidia Foundation under one or more agreements.
// The Mezidia Foundation licenses this file to you under the MIT license.

using System;

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
