﻿using Crimson.CSharp.Core;
using Crimson.CSharp.Exceptions;
using Crimson.CSharp.Generalising;
using Crimson.CSharp.Generalising.Structures;
using Crimson.CSharp.Parsing;
using Crimson.CSharp.Parsing.Statements;
using Crimson.CSharp.Parsing.Tokens;
using NLog;
using System.Text.RegularExpressions;

namespace Crimson.CSharp.Generalising
{
    internal class Generaliser
    {
        private static readonly Logger LOGGER = LogManager.GetCurrentClassLogger();

        public async Task<GeneralAssemblyProgram> Generalise (Compilation compilation)
        {
            GeneralAssemblyProgram program = new GeneralAssemblyProgram();

            Dictionary<string, FunctionCStatement> functions = new Dictionary<string, FunctionCStatement>();
            Dictionary<string, StructureCStatement> structures = new Dictionary<string, StructureCStatement>();
            Dictionary<string, GlobalVariableCStatement> globals = new Dictionary<string, GlobalVariableCStatement>();

            /*
             * Create 3 universal lists which contain all of the statements.
             * These have already been dynamically mapped (they know which singletons each call refers to).
             * During collection, these values are reassigned names (which are globally updated) to avoid name clashes.
             */
            foreach (Task<Scope> scope in compilation.Library.GetUnits())
            {
                foreach (var f in (await scope).Functions)
                {
                    functions.Add(f.Value.Name.ToString(), f.Value);
                }
                foreach (var s in (await scope).Structures)
                {
                    structures.Add(s.Value.Name.ToString(), s.Value);
                }
                foreach (var g in (await scope).GlobalVariables)
                {
                    globals.Add(g.Value.GetName().ToString(), g.Value);
                }
            }

            GeneralisationContext context = new GeneralisationContext(functions, structures, globals);

            // Add versioning and credits
            program.AddStructure(new CommentAssemblyStructure("This CrimsonBasic program was automatically generated by the Crimson compiler."));
            program.AddStructure(new CommentAssemblyStructure("Copyright (c) 2022-2023 GenElectrovise https://github.com/GenElectrovise and GamesMaster3000X https://github.com/gamesmaster3000x"));
            program.AddStructure(new CommentAssemblyStructure("Crimson version " + Core.Crimson.VERSION));
            program.AddStructure(new CommentAssemblyStructure("Crimson and RedFoxAssembly (RFASM) are parts of GamesMaster3000X's RedFoxVirtualMachine."));
            program.AddStructure(new CommentAssemblyStructure("The main repository for this project can be found at: https://github.com/gamesmaster3000x/RF_ASM"));
            program.AddStructure(new CommentAssemblyStructure("Crimson and RFASM were implemented by me, GenElectrovise."));
            program.AddStructure(new CommentAssemblyStructure("My development fork of the project can be found at: https://github.com/GenElectrovise/RF_ASM"));
            program.AddStructure(new CommentAssemblyStructure(""));

            // Add global variables
            LOGGER.Info("Generalising global variables");
            program.AddStructure(new CommentAssemblyStructure(""));
            program.AddStructure(new CommentAssemblyStructure("============================== Global Variables =============================="));
            foreach (var pair in globals)
            {
                IGeneralAssemblyStructure bs = pair.Value.Generalise(context);
                program.AddStructure(bs);
                LOGGER.Debug($"Added GlobalVariable {pair.Value.Assignment.Name}");
            }

            // Add main (entry) function
            program.AddStructure(new CommentAssemblyStructure(""));
            program.AddStructure(new CommentAssemblyStructure("============================== Entry Function =============================="));
            FunctionCStatement entryFunction = await compilation.GetEntryFunction();
            LOGGER.Info($"Found entry Function {entryFunction.Name}");
            IGeneralAssemblyStructure entryBs = entryFunction.Generalise(context);
            program.AddStructure(entryBs);
            LOGGER.Debug($"Added entry Function {entryFunction.Name}");

            // Add remaining functions
            LOGGER.Info("Generalising functions");
            program.AddStructure(new CommentAssemblyStructure(""));
            program.AddStructure(new CommentAssemblyStructure("============================== Functions =============================="));
            foreach (var pair in functions)
            {
                if (pair.Value == entryFunction) continue;
                IGeneralAssemblyStructure bs = pair.Value.Generalise(context);
                program.AddStructure(bs);
                LOGGER.Debug($"Added Function {pair.Value.Name}");
            }

            return program;
        }
    }
}
