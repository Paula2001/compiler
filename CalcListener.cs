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
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperation([NotNull] CalcParser.OperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperation([NotNull] CalcParser.OperationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] CalcParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] CalcParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] CalcParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] CalcParser.ValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] CalcParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] CalcParser.AssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.up"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUp([NotNull] CalcParser.UpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.up"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUp([NotNull] CalcParser.UpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.comparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparison([NotNull] CalcParser.ComparisonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.comparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparison([NotNull] CalcParser.ComparisonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.forLoop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForLoop([NotNull] CalcParser.ForLoopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.forLoop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForLoop([NotNull] CalcParser.ForLoopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] CalcParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] CalcParser.DeclarationContext context);
}
