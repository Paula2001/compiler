//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/paula/compiler/Calc.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class CalcLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, COMMENT=8, WS=9, 
		DATA_TYPE=10, ID=11, NUM=12, STRING=13, BOOLEAN=14;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "COMMENT", "WS", 
		"DATA_TYPE", "ID", "NUM", "STRING", "BOOLEAN"
	};


	public CalcLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CalcLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "':'", "'='", "';'", "'*'", "'/'", "'+'", "'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, "COMMENT", "WS", "DATA_TYPE", 
		"ID", "NUM", "STRING", "BOOLEAN"
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

	public override string GrammarFileName { get { return "Calc.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static CalcLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,14,116,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,1,0,
		1,0,1,1,1,1,1,2,1,2,1,3,1,3,1,4,1,4,1,5,1,5,1,6,1,6,1,7,1,7,1,7,1,7,5,
		7,48,8,7,10,7,12,7,51,9,7,1,7,1,7,1,8,4,8,56,8,8,11,8,12,8,57,1,8,1,8,
		1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,3,9,75,8,9,1,10,4,
		10,78,8,10,11,10,12,10,79,1,11,1,11,3,11,84,8,11,1,11,1,11,5,11,88,8,11,
		10,11,12,11,91,9,11,3,11,93,8,11,1,12,1,12,1,12,1,12,5,12,99,8,12,10,12,
		12,12,102,9,12,1,12,1,12,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,13,1,13,
		3,13,115,8,13,0,0,14,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,
		11,23,12,25,13,27,14,1,0,6,2,0,10,10,13,13,3,0,9,10,13,13,32,32,2,0,65,
		90,97,122,1,0,49,57,1,0,48,57,3,0,10,10,13,13,34,34,126,0,1,1,0,0,0,0,
		3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,
		0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,
		1,0,0,0,0,27,1,0,0,0,1,29,1,0,0,0,3,31,1,0,0,0,5,33,1,0,0,0,7,35,1,0,0,
		0,9,37,1,0,0,0,11,39,1,0,0,0,13,41,1,0,0,0,15,43,1,0,0,0,17,55,1,0,0,0,
		19,74,1,0,0,0,21,77,1,0,0,0,23,92,1,0,0,0,25,94,1,0,0,0,27,114,1,0,0,0,
		29,30,5,58,0,0,30,2,1,0,0,0,31,32,5,61,0,0,32,4,1,0,0,0,33,34,5,59,0,0,
		34,6,1,0,0,0,35,36,5,42,0,0,36,8,1,0,0,0,37,38,5,47,0,0,38,10,1,0,0,0,
		39,40,5,43,0,0,40,12,1,0,0,0,41,42,5,45,0,0,42,14,1,0,0,0,43,44,5,47,0,
		0,44,45,5,47,0,0,45,49,1,0,0,0,46,48,8,0,0,0,47,46,1,0,0,0,48,51,1,0,0,
		0,49,47,1,0,0,0,49,50,1,0,0,0,50,52,1,0,0,0,51,49,1,0,0,0,52,53,6,7,0,
		0,53,16,1,0,0,0,54,56,7,1,0,0,55,54,1,0,0,0,56,57,1,0,0,0,57,55,1,0,0,
		0,57,58,1,0,0,0,58,59,1,0,0,0,59,60,6,8,0,0,60,18,1,0,0,0,61,62,5,105,
		0,0,62,63,5,110,0,0,63,75,5,116,0,0,64,65,5,115,0,0,65,66,5,116,0,0,66,
		67,5,114,0,0,67,68,5,105,0,0,68,69,5,110,0,0,69,75,5,103,0,0,70,71,5,98,
		0,0,71,72,5,111,0,0,72,73,5,111,0,0,73,75,5,108,0,0,74,61,1,0,0,0,74,64,
		1,0,0,0,74,70,1,0,0,0,75,20,1,0,0,0,76,78,7,2,0,0,77,76,1,0,0,0,78,79,
		1,0,0,0,79,77,1,0,0,0,79,80,1,0,0,0,80,22,1,0,0,0,81,93,5,48,0,0,82,84,
		5,45,0,0,83,82,1,0,0,0,83,84,1,0,0,0,84,85,1,0,0,0,85,89,7,3,0,0,86,88,
		7,4,0,0,87,86,1,0,0,0,88,91,1,0,0,0,89,87,1,0,0,0,89,90,1,0,0,0,90,93,
		1,0,0,0,91,89,1,0,0,0,92,81,1,0,0,0,92,83,1,0,0,0,93,24,1,0,0,0,94,100,
		5,34,0,0,95,99,8,5,0,0,96,97,5,34,0,0,97,99,5,34,0,0,98,95,1,0,0,0,98,
		96,1,0,0,0,99,102,1,0,0,0,100,98,1,0,0,0,100,101,1,0,0,0,101,103,1,0,0,
		0,102,100,1,0,0,0,103,104,5,34,0,0,104,26,1,0,0,0,105,106,5,116,0,0,106,
		107,5,114,0,0,107,108,5,117,0,0,108,115,5,101,0,0,109,110,5,102,0,0,110,
		111,5,97,0,0,111,112,5,108,0,0,112,113,5,115,0,0,113,115,5,101,0,0,114,
		105,1,0,0,0,114,109,1,0,0,0,115,28,1,0,0,0,11,0,49,57,74,79,83,89,92,98,
		100,114,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
