﻿namespace Crimson.CSharp.Generalising.Structures
{
    public class ArbitraryAssemblyStructure : IGeneralAssemblyStructure
    {
        public string Text { get; protected set; }

        public ArbitraryAssemblyStructure (string text)
        {
            Text = text;
        }

        public override string ToString ()
        {
            return Text;
        }

        public IEnumerable<IGeneralAssemblyStructure> GetSubStructures ()
        {
            return Enumerable.Empty<IGeneralAssemblyStructure>();
        }
    }
}