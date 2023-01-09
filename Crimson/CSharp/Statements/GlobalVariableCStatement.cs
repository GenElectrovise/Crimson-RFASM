﻿using Crimson.CSharp.Core;
using CrimsonBasic.CSharp.Core;
using CrimsonBasic.CSharp.Core.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crimson.CSharp.Statements
{
    /// <summary>
    /// A uhm... global variable... Is a member of a package, rather than a function.
    /// </summary>
    public class GlobalVariableCStatement : GlobalCStatement
    {
        private CrimsonTypeCToken type;

        public GlobalVariableCStatement(CrimsonTypeCToken type, string identifier)
        {
            this.type = type;
            Name = identifier;
        }

        public GlobalVariableCStatement(CrimsonTypeCToken type, string identifier, ResolvableValueCToken? value) : this(type, identifier)
        {
            Value = value;
        }

        public ResolvableValueCToken? Value { get; }

        public override void Link(LinkingContext ctx)
        {
            return;
        }

        public Fragment GetCrimsonBasic()
        {
            Fragment statements = new Fragment(0);

            if (Value != null)
            {
                Fragment valueStatements = Value.GetCrimsonBasic();
                statements.Add(valueStatements);
            }

            statements.Add(new VariableDeclareBStatement(Name));
            statements.Add(new MemoryAllocateBStatement(Name, type.GetByteSize()));
            statements.Add(new VariableAssignBStatement(Name, "GLO_VAR_ASSIGN_VAL"));

            return statements;
        }
    }
}
