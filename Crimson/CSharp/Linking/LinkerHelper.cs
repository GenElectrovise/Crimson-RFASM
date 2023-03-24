﻿using Crimson.CSharp.Exceptions;
using Crimson.CSharp.Parsing;
using Crimson.CSharp.Parsing.Statements;
using Crimson.CSharp.Parsing.Tokens;

namespace Crimson.CSharp.Linking
{
    internal class LinkerHelper
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier">For example: "console.write"</param>
        /// <param name="ctx"></param>
        /// <returns></returns>
        /// <exception cref="LinkingException"></exception>
        internal static FunctionCStatement LinkFunctionCall (FullNameCToken identifier, LinkingContext ctx)
        {
            if (identifier == null) throw new LinkingException("Cannot link a null identifer");

            /*
             * Before:
             *  (#using "utils.crm" as u)
             *  u.help()
             * 
             * After:
             *  return FunctionCall("C:/utils.crm").GetFunction("help")
             */
            if (identifier.HasLibrary() && identifier.HasMember())
            {
                string alias = identifier.LibraryName;

                Scope scope = ctx.GetScope(alias);
                string funcName = identifier.MemberName;

                FunctionCStatement? func = scope.FindFunction(funcName);
                return func ?? throw new LinkingException($"External Function '{identifier}' does not exist in external {alias}:{scope}; " + ctx.ToString());
            }

            /*
             * Before:
             *  help()
             * 
             * After:
             *  return GetFunction("help")
             */
            if (identifier.HasMember())
            {
                string funcName = identifier.MemberName;
                FunctionCStatement? func = ctx.CurrentScope.FindFunction(funcName);

                return func ?? throw new LinkingException($"Internal Function '{identifier}' does not exist in internal {ctx.CurrentScope} or its parents; " + ctx.ToString());
            }

            // Somehow only has a library name?
            throw new LinkingException($"The idenifier {identifier} with no member name somehow got through the parsing process?");
        }

        [Obsolete]
        internal static FullNameCToken LinkIdentifier (FullNameCToken identifier, LinkingContext ctx)
        {
            if (identifier == null) throw new LinkingException("Cannot link a null identifer");

            /*
             * Before:
             *  (#using "utils.crm" as u)
             *  u.help
             * 
             * After:
             *  ${utils.crm}.help
             */
            if (identifier.HasLibrary() && identifier.HasMember())
            {
                string alias = identifier.LibraryName!;

                Scope unit = ctx.GetScope(alias);
                string call = identifier.MemberName;

                FullNameCToken output = new FullNameCToken($"{{{unit}}}", call); // {{ is used to escape the {, creating ${path}.call in the end //TODO LinkerHelper casts Unit to string
                return output;
            }

            // Is a short local name with no library, so no linking needed
            if (identifier.HasMember())
            {
                return new FullNameCToken(null, identifier.MemberName);
            }

            // Somehow only has a library name?
            throw new LinkingException($"The idenifier {identifier} with no member name somehow got through the parsing process?");
        }
    }
}