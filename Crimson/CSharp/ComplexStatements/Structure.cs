﻿namespace Crimson.CSharp.Statements
{
    internal class Structure : GlobalStatement
    {
        public Structure(string identifier, IList<InternalStatement> body)
        {
            Identifier = identifier;
            Body = body;
        }

        public string Identifier { get; set; }
        public IList<InternalStatement> Body { get; }
    }
}