﻿using NLog;
using CrimsonCore.Generalising;

namespace CrimsonCore.Specialising.RFASM
{
    internal class RFASMSpecialiser : ISpecialiser
    {
        private static readonly Logger LOGGER = LogManager.GetCurrentClassLogger();

        public AbstractSpecificAssemblyProgram Specialise (GeneralAssemblyProgram general)
        {
            RFASMProgram program = new RFASMProgram();

            foreach (var s in general.Structures)
                program.Add(new RFASMComment(s.ToString()));

            return program;
        }
    }
}
