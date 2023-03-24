﻿namespace Crimson.CSharp.Generalising.Structures
{
    public class EmptyAssemblyStructure : IGeneralAssemblyStructure
    {
        public EmptyAssemblyStructure ()
        {
        }

        public IEnumerable<IGeneralAssemblyStructure> GetSubStructures ()
        {
            return Enumerable.Empty<IGeneralAssemblyStructure>();
        }
    }
}