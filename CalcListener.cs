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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CalcParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface ICalcListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] CalcParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] CalcParser.ProgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl([NotNull] CalcParser.DeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl([NotNull] CalcParser.DeclContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.assignExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignExpr([NotNull] CalcParser.AssignExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.assignExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignExpr([NotNull] CalcParser.AssignExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] CalcParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] CalcParser.ExprContext context);
}
