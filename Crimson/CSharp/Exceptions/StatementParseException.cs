﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crimson.CSharp.Exceptions
{
    internal class StatementParseException : ArgumentException
    {
        public StatementParseException (string message) : base(message)
        {

        }

        public StatementParseException (string message, Exception cause) : base(message, cause)
        {

        }
    }
}
