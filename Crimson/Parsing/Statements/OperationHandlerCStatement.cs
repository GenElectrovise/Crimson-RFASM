﻿using Crimson.Generalising.Structures;
using Crimson.Specialising;
using Crimson.Generalising;
using Crimson.Linking;
using Crimson.Parsing.Tokens;
using Crimson.Parsing.Tokens.Values;

namespace Crimson.Parsing.Statements
{
    public class OperationHandlerCStatement : AbstractCrimsonStatement
    {
        public OperationResolvableValueCToken.OperationType OpType { get; protected set; }
        public FullNameCToken FunctionIdentifier { get; protected set; }
        public FunctionCStatement? TargetFunction { get; protected set; }

        public OperationHandlerCStatement (OperationResolvableValueCToken.OperationType opType, FullNameCToken identifier)
        {
            OpType = opType;
            FunctionIdentifier = identifier;
        }

        public FunctionCallCStatement Apply (FunctionArgumentCToken arg1, FunctionArgumentCToken arg2)
        {
            return null;
        }

        public override void Link (LinkingContext ctx)
        {
            TargetFunction = LinkerHelper.LinkFunctionCall(FunctionIdentifier, ctx);
        }

        public override IGeneralAssemblyStructure Generalise (GeneralisationContext context)
        {
            return new EmptyAssemblyStructure();
        }
    }
}