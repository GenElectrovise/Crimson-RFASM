﻿using CrimsonCore.Generalising;

namespace CrimsonCore.Generalising.Structures
{
    public class ReturnAssemblyStructure : IGeneralAssemblyStructure
    {
        public ReturnAssemblyStructure ()
        {
        }

        public IEnumerable<IGeneralAssemblyStructure> GetSubStructures ()
        {
            return Enumerable.Empty<IGeneralAssemblyStructure>();
        }

        public override string ToString ()
        {
            return "RET";
        }
    }
}