﻿using CrimsonCore.Exceptions;
using CrimsonCore.Specialising;
using System;
using CrimsonCore.Linking;
using CrimsonCore.Generalising.Structures;
using CrimsonCore.Parsing.Tokens.Values;
using CrimsonCore.Generalising;
using CrimsonCore.Parsing.Tokens;

namespace CrimsonCore.Parsing.Statements
{
    public class VariableAssignmentCStatement : AbstractCrimsonStatement
    {

        public FullNameCToken Name { get; set; }
        public SimpleValueCToken Size { get; set; }
        public SimpleValueCToken? Simple { get; }
        public ComplexValueCToken? Complex { get; }

        public VariableAssignmentCStatement (FullNameCToken identifier, SimpleValueCToken size, SimpleValueCToken value)
        {
            Name = identifier;
            Size = size;
            Simple = value;
        }

        public VariableAssignmentCStatement (FullNameCToken identifier, SimpleValueCToken size, ComplexValueCToken value)
        {
            Name = identifier;
            Size = size;
            Complex = value;
        }

        public override void Link (LinkingContext ctx)
        {
            Name = LinkerHelper.LinkIdentifier(Name, ctx);
            Simple?.Link(ctx);
            Complex?.Link(ctx);
            Linked = true;
        }

        public override IGeneralAssemblyStructure Generalise (GeneralisationContext context)
        {
            ScopeAssemblyStructure result = new ScopeAssemblyStructure();

            result.AddSubStructure(new CommentAssemblyStructure($"{Name}<{Size}>={Simple}/{Complex}"));

            /* if (Simple != null)
                 result.AddSubStructure(new CommentAssemblyStructure(Simple.GetText()));
             else if (Complex != null)
             {
                 result.AddSubStructure(new CommentAssemblyStructure("Complex Fragment"));
                 result.AddSubStructure(new CommentAssemblyStructure($"Variable Assign {Name.ToString()}=VAR_ASSIGN_C_VAL"));
             }
             else
                 throw new FlatteningException($"No value to be assigned to variable {Name}");*/

            return result;
        }

        internal bool IsKnownAtCompileTime ()
        {
            throw new NotImplementedException();
        }
    }
}