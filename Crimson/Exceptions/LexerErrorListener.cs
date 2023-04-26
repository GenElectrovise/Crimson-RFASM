﻿using Antlr4.Runtime;
using NLog;

namespace CrimsonCore.Exceptions
{
    internal class LexerErrorListener : IAntlrErrorListener<int>
    {
        public static readonly Logger LOGGER = LogManager.GetCurrentClassLogger();

        private string Name { get; set; }
        public LexerErrorListener (string name)
        {
            Name = name;
        }

        public void SyntaxError (TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            CrimsonCore.Panic($"A lexer error has occurred lexing {Name}", CrimsonCore.PanicCode.COMPILE_PARSE, null!);
        }
    }
}
