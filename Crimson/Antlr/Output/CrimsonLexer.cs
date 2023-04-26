//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Input/Crimson.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace CrimsonCore.AntlrBuild {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public partial class CrimsonLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		Allocator=1, Function=2, Global=3, Scope=4, Return=5, Structure=6, Using=7, 
		OpHandler=8, As=9, If=10, While=11, Else=12, Elif=13, Operator=14, Asterisk=15, 
		MathsOperator=16, Comparator=17, RightArrow=18, BasicCall=19, AssemblyCall=20, 
		DirectEquals=21, PointerEquals=22, OpenBracket=23, CloseBracket=24, OpenSquare=25, 
		CloseSquare=26, Colon=27, OpenBrace=28, CloseBrace=29, OpenTriangle=30, 
		CloseTriangle=31, Comma=32, Dot=33, SemiColon=34, Underscore=35, Hashtag=36, 
		Quote=37, SkipTokens=38, LineComment=39, BlockComment=40, Number=41, String=42, 
		ShortName=43;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"Allocator", "Function", "Global", "Scope", "Return", "Structure", "Using", 
		"OpHandler", "As", "If", "While", "Else", "Elif", "Operator", "Plus", 
		"Minus", "Asterisk", "Slash", "MathsOperator", "Less", "LessEqual", "Greater", 
		"GreaterEqual", "EqualTo", "Comparator", "RightArrow", "BasicCall", "AssemblyCall", 
		"DirectEquals", "PointerEquals", "OpenBracket", "CloseBracket", "OpenSquare", 
		"CloseSquare", "Colon", "OpenBrace", "CloseBrace", "OpenTriangle", "CloseTriangle", 
		"Comma", "Dot", "SemiColon", "Underscore", "Hashtag", "Quote", "SkipTokens", 
		"LineComment", "BlockComment", "Number", "String", "ShortName", "Alphabetic", 
		"Digit", "Punctuation", "WhiteSpace", "Newline"
	};


	public CrimsonLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CrimsonLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'allocator'", "'function'", "'global'", "'scope'", "'return'", 
		"'structure'", "'using'", "'ophandler'", "'as'", "'if'", "'while'", "'else'", 
		"'elif'", null, "'*'", null, null, "'->'", "'B~'", "'A~'", "'='", "'*='", 
		"'('", "')'", "'['", "']'", "':'", "'{'", "'}'", "'<'", "'>'", "','", 
		"'.'", "';'", "'_'", "'#'", "'\"'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "Allocator", "Function", "Global", "Scope", "Return", "Structure", 
		"Using", "OpHandler", "As", "If", "While", "Else", "Elif", "Operator", 
		"Asterisk", "MathsOperator", "Comparator", "RightArrow", "BasicCall", 
		"AssemblyCall", "DirectEquals", "PointerEquals", "OpenBracket", "CloseBracket", 
		"OpenSquare", "CloseSquare", "Colon", "OpenBrace", "CloseBrace", "OpenTriangle", 
		"CloseTriangle", "Comma", "Dot", "SemiColon", "Underscore", "Hashtag", 
		"Quote", "SkipTokens", "LineComment", "BlockComment", "Number", "String", 
		"ShortName"
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

	public override string GrammarFileName { get { return "Crimson.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static CrimsonLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,43,357,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,1,0,1,
		0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
		1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,3,1,3,1,3,1,3,1,3,1,3,1,4,1,4,1,4,1,4,1,
		4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,
		1,6,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,9,1,9,1,9,1,
		10,1,10,1,10,1,10,1,10,1,10,1,11,1,11,1,11,1,11,1,11,1,12,1,12,1,12,1,
		12,1,12,1,13,1,13,3,13,203,8,13,1,14,1,14,1,15,1,15,1,16,1,16,1,17,1,17,
		1,18,1,18,1,18,1,18,3,18,217,8,18,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,
		21,1,21,1,21,1,21,1,22,1,22,1,22,1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,
		24,3,24,241,8,24,1,25,1,25,1,25,1,26,1,26,1,26,1,27,1,27,1,27,1,28,1,28,
		1,29,1,29,1,29,1,30,1,30,1,31,1,31,1,32,1,32,1,33,1,33,1,34,1,34,1,35,
		1,35,1,36,1,36,1,37,1,37,1,38,1,38,1,39,1,39,1,40,1,40,1,41,1,41,1,42,
		1,42,1,43,1,43,1,44,1,44,1,45,1,45,1,45,1,45,3,45,291,8,45,1,45,1,45,1,
		46,1,46,1,46,1,46,5,46,299,8,46,10,46,12,46,302,9,46,1,47,1,47,1,47,1,
		47,5,47,308,8,47,10,47,12,47,311,9,47,1,47,1,47,1,47,1,48,4,48,317,8,48,
		11,48,12,48,318,1,49,1,49,5,49,323,8,49,10,49,12,49,326,9,49,1,49,1,49,
		1,50,1,50,1,50,1,50,5,50,334,8,50,10,50,12,50,337,9,50,1,51,1,51,1,52,
		1,52,1,53,1,53,1,54,4,54,346,8,54,11,54,12,54,347,1,55,4,55,351,8,55,11,
		55,12,55,352,1,55,3,55,356,8,55,1,309,0,56,1,1,3,2,5,3,7,4,9,5,11,6,13,
		7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,0,31,0,33,15,35,0,37,16,39,
		0,41,0,43,0,45,0,47,0,49,17,51,18,53,19,55,20,57,21,59,22,61,23,63,24,
		65,25,67,26,69,27,71,28,73,29,75,30,77,31,79,32,81,33,83,34,85,35,87,36,
		89,37,91,38,93,39,95,40,97,41,99,42,101,43,103,0,105,0,107,0,109,0,111,
		0,1,0,6,2,0,10,10,13,13,1,0,34,34,2,0,65,90,97,122,1,0,48,57,2,0,46,46,
		95,95,2,0,9,9,32,32,364,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,
		0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,
		1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,33,1,0,0,
		0,0,37,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,
		1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,
		0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,
		1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,
		0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,
		1,0,0,0,1,113,1,0,0,0,3,123,1,0,0,0,5,132,1,0,0,0,7,139,1,0,0,0,9,145,
		1,0,0,0,11,152,1,0,0,0,13,162,1,0,0,0,15,168,1,0,0,0,17,178,1,0,0,0,19,
		181,1,0,0,0,21,184,1,0,0,0,23,190,1,0,0,0,25,195,1,0,0,0,27,202,1,0,0,
		0,29,204,1,0,0,0,31,206,1,0,0,0,33,208,1,0,0,0,35,210,1,0,0,0,37,216,1,
		0,0,0,39,218,1,0,0,0,41,222,1,0,0,0,43,225,1,0,0,0,45,229,1,0,0,0,47,232,
		1,0,0,0,49,240,1,0,0,0,51,242,1,0,0,0,53,245,1,0,0,0,55,248,1,0,0,0,57,
		251,1,0,0,0,59,253,1,0,0,0,61,256,1,0,0,0,63,258,1,0,0,0,65,260,1,0,0,
		0,67,262,1,0,0,0,69,264,1,0,0,0,71,266,1,0,0,0,73,268,1,0,0,0,75,270,1,
		0,0,0,77,272,1,0,0,0,79,274,1,0,0,0,81,276,1,0,0,0,83,278,1,0,0,0,85,280,
		1,0,0,0,87,282,1,0,0,0,89,284,1,0,0,0,91,290,1,0,0,0,93,294,1,0,0,0,95,
		303,1,0,0,0,97,316,1,0,0,0,99,320,1,0,0,0,101,329,1,0,0,0,103,338,1,0,
		0,0,105,340,1,0,0,0,107,342,1,0,0,0,109,345,1,0,0,0,111,355,1,0,0,0,113,
		114,5,97,0,0,114,115,5,108,0,0,115,116,5,108,0,0,116,117,5,111,0,0,117,
		118,5,99,0,0,118,119,5,97,0,0,119,120,5,116,0,0,120,121,5,111,0,0,121,
		122,5,114,0,0,122,2,1,0,0,0,123,124,5,102,0,0,124,125,5,117,0,0,125,126,
		5,110,0,0,126,127,5,99,0,0,127,128,5,116,0,0,128,129,5,105,0,0,129,130,
		5,111,0,0,130,131,5,110,0,0,131,4,1,0,0,0,132,133,5,103,0,0,133,134,5,
		108,0,0,134,135,5,111,0,0,135,136,5,98,0,0,136,137,5,97,0,0,137,138,5,
		108,0,0,138,6,1,0,0,0,139,140,5,115,0,0,140,141,5,99,0,0,141,142,5,111,
		0,0,142,143,5,112,0,0,143,144,5,101,0,0,144,8,1,0,0,0,145,146,5,114,0,
		0,146,147,5,101,0,0,147,148,5,116,0,0,148,149,5,117,0,0,149,150,5,114,
		0,0,150,151,5,110,0,0,151,10,1,0,0,0,152,153,5,115,0,0,153,154,5,116,0,
		0,154,155,5,114,0,0,155,156,5,117,0,0,156,157,5,99,0,0,157,158,5,116,0,
		0,158,159,5,117,0,0,159,160,5,114,0,0,160,161,5,101,0,0,161,12,1,0,0,0,
		162,163,5,117,0,0,163,164,5,115,0,0,164,165,5,105,0,0,165,166,5,110,0,
		0,166,167,5,103,0,0,167,14,1,0,0,0,168,169,5,111,0,0,169,170,5,112,0,0,
		170,171,5,104,0,0,171,172,5,97,0,0,172,173,5,110,0,0,173,174,5,100,0,0,
		174,175,5,108,0,0,175,176,5,101,0,0,176,177,5,114,0,0,177,16,1,0,0,0,178,
		179,5,97,0,0,179,180,5,115,0,0,180,18,1,0,0,0,181,182,5,105,0,0,182,183,
		5,102,0,0,183,20,1,0,0,0,184,185,5,119,0,0,185,186,5,104,0,0,186,187,5,
		105,0,0,187,188,5,108,0,0,188,189,5,101,0,0,189,22,1,0,0,0,190,191,5,101,
		0,0,191,192,5,108,0,0,192,193,5,115,0,0,193,194,5,101,0,0,194,24,1,0,0,
		0,195,196,5,101,0,0,196,197,5,108,0,0,197,198,5,105,0,0,198,199,5,102,
		0,0,199,26,1,0,0,0,200,203,3,49,24,0,201,203,3,37,18,0,202,200,1,0,0,0,
		202,201,1,0,0,0,203,28,1,0,0,0,204,205,5,43,0,0,205,30,1,0,0,0,206,207,
		5,45,0,0,207,32,1,0,0,0,208,209,5,42,0,0,209,34,1,0,0,0,210,211,5,47,0,
		0,211,36,1,0,0,0,212,217,3,29,14,0,213,217,3,31,15,0,214,217,3,33,16,0,
		215,217,3,35,17,0,216,212,1,0,0,0,216,213,1,0,0,0,216,214,1,0,0,0,216,
		215,1,0,0,0,217,38,1,0,0,0,218,219,5,60,0,0,219,220,5,60,0,0,220,221,5,
		62,0,0,221,40,1,0,0,0,222,223,5,60,0,0,223,224,5,61,0,0,224,42,1,0,0,0,
		225,226,5,60,0,0,226,227,5,62,0,0,227,228,5,62,0,0,228,44,1,0,0,0,229,
		230,5,62,0,0,230,231,5,61,0,0,231,46,1,0,0,0,232,233,5,61,0,0,233,234,
		5,61,0,0,234,48,1,0,0,0,235,241,3,39,19,0,236,241,3,41,20,0,237,241,3,
		43,21,0,238,241,3,45,22,0,239,241,3,47,23,0,240,235,1,0,0,0,240,236,1,
		0,0,0,240,237,1,0,0,0,240,238,1,0,0,0,240,239,1,0,0,0,241,50,1,0,0,0,242,
		243,5,45,0,0,243,244,5,62,0,0,244,52,1,0,0,0,245,246,5,66,0,0,246,247,
		5,126,0,0,247,54,1,0,0,0,248,249,5,65,0,0,249,250,5,126,0,0,250,56,1,0,
		0,0,251,252,5,61,0,0,252,58,1,0,0,0,253,254,5,42,0,0,254,255,5,61,0,0,
		255,60,1,0,0,0,256,257,5,40,0,0,257,62,1,0,0,0,258,259,5,41,0,0,259,64,
		1,0,0,0,260,261,5,91,0,0,261,66,1,0,0,0,262,263,5,93,0,0,263,68,1,0,0,
		0,264,265,5,58,0,0,265,70,1,0,0,0,266,267,5,123,0,0,267,72,1,0,0,0,268,
		269,5,125,0,0,269,74,1,0,0,0,270,271,5,60,0,0,271,76,1,0,0,0,272,273,5,
		62,0,0,273,78,1,0,0,0,274,275,5,44,0,0,275,80,1,0,0,0,276,277,5,46,0,0,
		277,82,1,0,0,0,278,279,5,59,0,0,279,84,1,0,0,0,280,281,5,95,0,0,281,86,
		1,0,0,0,282,283,5,35,0,0,283,88,1,0,0,0,284,285,5,34,0,0,285,90,1,0,0,
		0,286,291,3,109,54,0,287,291,3,111,55,0,288,291,3,93,46,0,289,291,3,95,
		47,0,290,286,1,0,0,0,290,287,1,0,0,0,290,288,1,0,0,0,290,289,1,0,0,0,291,
		292,1,0,0,0,292,293,6,45,0,0,293,92,1,0,0,0,294,295,5,47,0,0,295,296,5,
		47,0,0,296,300,1,0,0,0,297,299,8,0,0,0,298,297,1,0,0,0,299,302,1,0,0,0,
		300,298,1,0,0,0,300,301,1,0,0,0,301,94,1,0,0,0,302,300,1,0,0,0,303,304,
		5,47,0,0,304,305,5,42,0,0,305,309,1,0,0,0,306,308,9,0,0,0,307,306,1,0,
		0,0,308,311,1,0,0,0,309,310,1,0,0,0,309,307,1,0,0,0,310,312,1,0,0,0,311,
		309,1,0,0,0,312,313,5,42,0,0,313,314,5,47,0,0,314,96,1,0,0,0,315,317,3,
		105,52,0,316,315,1,0,0,0,317,318,1,0,0,0,318,316,1,0,0,0,318,319,1,0,0,
		0,319,98,1,0,0,0,320,324,3,89,44,0,321,323,8,1,0,0,322,321,1,0,0,0,323,
		326,1,0,0,0,324,322,1,0,0,0,324,325,1,0,0,0,325,327,1,0,0,0,326,324,1,
		0,0,0,327,328,3,89,44,0,328,100,1,0,0,0,329,335,3,103,51,0,330,334,3,103,
		51,0,331,334,3,97,48,0,332,334,3,85,42,0,333,330,1,0,0,0,333,331,1,0,0,
		0,333,332,1,0,0,0,334,337,1,0,0,0,335,333,1,0,0,0,335,336,1,0,0,0,336,
		102,1,0,0,0,337,335,1,0,0,0,338,339,7,2,0,0,339,104,1,0,0,0,340,341,7,
		3,0,0,341,106,1,0,0,0,342,343,7,4,0,0,343,108,1,0,0,0,344,346,7,5,0,0,
		345,344,1,0,0,0,346,347,1,0,0,0,347,345,1,0,0,0,347,348,1,0,0,0,348,110,
		1,0,0,0,349,351,7,0,0,0,350,349,1,0,0,0,351,352,1,0,0,0,352,350,1,0,0,
		0,352,353,1,0,0,0,353,356,1,0,0,0,354,356,5,0,0,1,355,350,1,0,0,0,355,
		354,1,0,0,0,356,112,1,0,0,0,14,0,202,216,240,290,300,309,318,324,333,335,
		347,352,355,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace CrimsonCore.AntlrBuild
