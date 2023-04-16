﻿using Crimson.Specialising;
using Crimson.Linking;

namespace Crimson.Parsing.Tokens
{
    internal class ElseBlockCToken : ICrimsonToken, IHasScope
    {
        public ElseBlockCToken (Scope statements)
        {
            Scope = statements;
        }

        public Scope Scope { get; }

        public Scope GetScope () => Scope;

        public void Link (LinkingContext ctx)
        {
            Scope.Link(ctx);
            return;
        }
    }
}