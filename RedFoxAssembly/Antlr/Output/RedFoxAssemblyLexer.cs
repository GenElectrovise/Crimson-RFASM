//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Input/RedFoxAssembly.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace RedFoxAssembly.AntlrBuild {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public partial class RedFoxAssemblyLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		Label=1, Width=2, Value=3, HLT=4, NOP=5, ADD=6, SUB=7, LSL=8, LSR=9, NEG=10, 
		NOT=11, CMP=12, JMP=13, BFG=14, BSR=15, RTN=16, RRB=17, RRW=18, RMB=19, 
		RMW=20, WRB=21, WRW=22, WMB=23, WMW=24, RVB=25, RVW=26, SIN=27, INT=28, 
		SFG=29, AND=30, LOR=31, XOR=32, Underscore=33, Quote=34, Comma=35, Number=36, 
		ByteLetter=37, Identifier=38;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"Label", "Width", "Value", "HLT", "NOP", "ADD", "SUB", "LSL", "LSR", "NEG", 
		"NOT", "CMP", "JMP", "BFG", "BSR", "RTN", "RRB", "RRW", "RMB", "RMW", 
		"WRB", "WRW", "WMB", "WMW", "RVB", "RVW", "SIN", "INT", "SFG", "AND", 
		"LOR", "XOR", "Underscore", "Quote", "Comma", "Number", "ByteLetter", 
		"Identifier", "Alphabetic", "Digit", "WhiteSpace", "Newline"
	};


	public RedFoxAssemblyLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public RedFoxAssemblyLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'::'", "'.width'", "'.value'", "'HLT'", "'NOP'", "'ADD'", "'SUB'", 
		"'LSL'", "'LSR'", "'NEG'", "'NOT'", "'CMP'", "'JMP'", "'BFG'", "'BSR'", 
		"'RTN'", "'RRB'", "'RRW'", "'RMB'", "'RMW'", "'WRB'", "'WRW'", "'WMB'", 
		"'WMW'", "'RVB'", "'RVW'", "'SIN'", "'INT'", "'SFG'", "'AND'", "'LOR'", 
		"'XOR'", "'_'", "'''", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "Label", "Width", "Value", "HLT", "NOP", "ADD", "SUB", "LSL", "LSR", 
		"NEG", "NOT", "CMP", "JMP", "BFG", "BSR", "RTN", "RRB", "RRW", "RMB", 
		"RMW", "WRB", "WRW", "WMB", "WMW", "RVB", "RVW", "SIN", "INT", "SFG", 
		"AND", "LOR", "XOR", "Underscore", "Quote", "Comma", "Number", "ByteLetter", 
		"Identifier"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "RedFoxAssembly.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static RedFoxAssemblyLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,38,264,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,1,0,1,
		0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,3,1,3,
		1,3,1,3,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,
		7,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,1,11,1,11,1,11,1,
		11,1,12,1,12,1,12,1,12,1,13,1,13,1,13,1,13,1,14,1,14,1,14,1,14,1,15,1,
		15,1,15,1,15,1,16,1,16,1,16,1,16,1,17,1,17,1,17,1,17,1,18,1,18,1,18,1,
		18,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,21,1,21,1,21,1,21,1,22,1,
		22,1,22,1,22,1,23,1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,25,1,25,1,25,1,
		25,1,26,1,26,1,26,1,26,1,27,1,27,1,27,1,27,1,28,1,28,1,28,1,28,1,29,1,
		29,1,29,1,29,1,30,1,30,1,30,1,30,1,31,1,31,1,31,1,31,1,32,1,32,1,33,1,
		33,1,34,1,34,1,35,4,35,226,8,35,11,35,12,35,227,1,36,1,36,1,37,1,37,1,
		37,1,37,1,37,5,37,237,8,37,10,37,12,37,240,9,37,1,37,1,37,3,37,244,8,37,
		3,37,246,8,37,1,38,1,38,1,39,1,39,1,40,4,40,253,8,40,11,40,12,40,254,1,
		41,4,41,258,8,41,11,41,12,41,259,1,41,3,41,263,8,41,0,0,42,1,1,3,2,5,3,
		7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,
		33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,
		57,29,59,30,61,31,63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,0,79,0,
		81,0,83,0,1,0,5,2,0,65,70,97,102,2,0,65,90,97,122,1,0,48,57,2,0,9,9,32,
		32,2,0,10,10,13,13,268,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,
		0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,
		0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,
		0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,
		1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,
		0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,
		1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,
		0,0,75,1,0,0,0,1,85,1,0,0,0,3,88,1,0,0,0,5,95,1,0,0,0,7,102,1,0,0,0,9,
		106,1,0,0,0,11,110,1,0,0,0,13,114,1,0,0,0,15,118,1,0,0,0,17,122,1,0,0,
		0,19,126,1,0,0,0,21,130,1,0,0,0,23,134,1,0,0,0,25,138,1,0,0,0,27,142,1,
		0,0,0,29,146,1,0,0,0,31,150,1,0,0,0,33,154,1,0,0,0,35,158,1,0,0,0,37,162,
		1,0,0,0,39,166,1,0,0,0,41,170,1,0,0,0,43,174,1,0,0,0,45,178,1,0,0,0,47,
		182,1,0,0,0,49,186,1,0,0,0,51,190,1,0,0,0,53,194,1,0,0,0,55,198,1,0,0,
		0,57,202,1,0,0,0,59,206,1,0,0,0,61,210,1,0,0,0,63,214,1,0,0,0,65,218,1,
		0,0,0,67,220,1,0,0,0,69,222,1,0,0,0,71,225,1,0,0,0,73,229,1,0,0,0,75,245,
		1,0,0,0,77,247,1,0,0,0,79,249,1,0,0,0,81,252,1,0,0,0,83,262,1,0,0,0,85,
		86,5,58,0,0,86,87,5,58,0,0,87,2,1,0,0,0,88,89,5,46,0,0,89,90,5,119,0,0,
		90,91,5,105,0,0,91,92,5,100,0,0,92,93,5,116,0,0,93,94,5,104,0,0,94,4,1,
		0,0,0,95,96,5,46,0,0,96,97,5,118,0,0,97,98,5,97,0,0,98,99,5,108,0,0,99,
		100,5,117,0,0,100,101,5,101,0,0,101,6,1,0,0,0,102,103,5,72,0,0,103,104,
		5,76,0,0,104,105,5,84,0,0,105,8,1,0,0,0,106,107,5,78,0,0,107,108,5,79,
		0,0,108,109,5,80,0,0,109,10,1,0,0,0,110,111,5,65,0,0,111,112,5,68,0,0,
		112,113,5,68,0,0,113,12,1,0,0,0,114,115,5,83,0,0,115,116,5,85,0,0,116,
		117,5,66,0,0,117,14,1,0,0,0,118,119,5,76,0,0,119,120,5,83,0,0,120,121,
		5,76,0,0,121,16,1,0,0,0,122,123,5,76,0,0,123,124,5,83,0,0,124,125,5,82,
		0,0,125,18,1,0,0,0,126,127,5,78,0,0,127,128,5,69,0,0,128,129,5,71,0,0,
		129,20,1,0,0,0,130,131,5,78,0,0,131,132,5,79,0,0,132,133,5,84,0,0,133,
		22,1,0,0,0,134,135,5,67,0,0,135,136,5,77,0,0,136,137,5,80,0,0,137,24,1,
		0,0,0,138,139,5,74,0,0,139,140,5,77,0,0,140,141,5,80,0,0,141,26,1,0,0,
		0,142,143,5,66,0,0,143,144,5,70,0,0,144,145,5,71,0,0,145,28,1,0,0,0,146,
		147,5,66,0,0,147,148,5,83,0,0,148,149,5,82,0,0,149,30,1,0,0,0,150,151,
		5,82,0,0,151,152,5,84,0,0,152,153,5,78,0,0,153,32,1,0,0,0,154,155,5,82,
		0,0,155,156,5,82,0,0,156,157,5,66,0,0,157,34,1,0,0,0,158,159,5,82,0,0,
		159,160,5,82,0,0,160,161,5,87,0,0,161,36,1,0,0,0,162,163,5,82,0,0,163,
		164,5,77,0,0,164,165,5,66,0,0,165,38,1,0,0,0,166,167,5,82,0,0,167,168,
		5,77,0,0,168,169,5,87,0,0,169,40,1,0,0,0,170,171,5,87,0,0,171,172,5,82,
		0,0,172,173,5,66,0,0,173,42,1,0,0,0,174,175,5,87,0,0,175,176,5,82,0,0,
		176,177,5,87,0,0,177,44,1,0,0,0,178,179,5,87,0,0,179,180,5,77,0,0,180,
		181,5,66,0,0,181,46,1,0,0,0,182,183,5,87,0,0,183,184,5,77,0,0,184,185,
		5,87,0,0,185,48,1,0,0,0,186,187,5,82,0,0,187,188,5,86,0,0,188,189,5,66,
		0,0,189,50,1,0,0,0,190,191,5,82,0,0,191,192,5,86,0,0,192,193,5,87,0,0,
		193,52,1,0,0,0,194,195,5,83,0,0,195,196,5,73,0,0,196,197,5,78,0,0,197,
		54,1,0,0,0,198,199,5,73,0,0,199,200,5,78,0,0,200,201,5,84,0,0,201,56,1,
		0,0,0,202,203,5,83,0,0,203,204,5,70,0,0,204,205,5,71,0,0,205,58,1,0,0,
		0,206,207,5,65,0,0,207,208,5,78,0,0,208,209,5,68,0,0,209,60,1,0,0,0,210,
		211,5,76,0,0,211,212,5,79,0,0,212,213,5,82,0,0,213,62,1,0,0,0,214,215,
		5,88,0,0,215,216,5,79,0,0,216,217,5,82,0,0,217,64,1,0,0,0,218,219,5,95,
		0,0,219,66,1,0,0,0,220,221,5,39,0,0,221,68,1,0,0,0,222,223,5,44,0,0,223,
		70,1,0,0,0,224,226,3,79,39,0,225,224,1,0,0,0,226,227,1,0,0,0,227,225,1,
		0,0,0,227,228,1,0,0,0,228,72,1,0,0,0,229,230,7,0,0,0,230,74,1,0,0,0,231,
		246,3,77,38,0,232,238,3,77,38,0,233,237,3,77,38,0,234,237,3,71,35,0,235,
		237,3,65,32,0,236,233,1,0,0,0,236,234,1,0,0,0,236,235,1,0,0,0,237,240,
		1,0,0,0,238,236,1,0,0,0,238,239,1,0,0,0,239,243,1,0,0,0,240,238,1,0,0,
		0,241,244,3,77,38,0,242,244,3,71,35,0,243,241,1,0,0,0,243,242,1,0,0,0,
		244,246,1,0,0,0,245,231,1,0,0,0,245,232,1,0,0,0,246,76,1,0,0,0,247,248,
		7,1,0,0,248,78,1,0,0,0,249,250,7,2,0,0,250,80,1,0,0,0,251,253,7,3,0,0,
		252,251,1,0,0,0,253,254,1,0,0,0,254,252,1,0,0,0,254,255,1,0,0,0,255,82,
		1,0,0,0,256,258,7,4,0,0,257,256,1,0,0,0,258,259,1,0,0,0,259,257,1,0,0,
		0,259,260,1,0,0,0,260,263,1,0,0,0,261,263,5,0,0,1,262,257,1,0,0,0,262,
		261,1,0,0,0,263,84,1,0,0,0,9,0,227,236,238,243,245,254,259,262,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace RedFoxAssembly.AntlrBuild