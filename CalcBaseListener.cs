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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICalcListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class CalcBaseListener : ICalcListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProg([NotNull] CalcParser.ProgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProg([NotNull] CalcParser.ProgContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.decl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl([NotNull] CalcParser.DeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.decl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl([NotNull] CalcParser.DeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.assignExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignExpr([NotNull] CalcParser.AssignExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.assignExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignExpr([NotNull] CalcParser.AssignExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] CalcParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] CalcParser.ExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] CalcParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] CalcParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] CalcParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] CalcParser.AssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.up"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUp([NotNull] CalcParser.UpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.up"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUp([NotNull] CalcParser.UpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.comparison"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparison([NotNull] CalcParser.ComparisonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.comparison"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparison([NotNull] CalcParser.ComparisonContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.forLoop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForLoop([NotNull] CalcParser.ForLoopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.forLoop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForLoop([NotNull] CalcParser.ForLoopContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalcParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] CalcParser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalcParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] CalcParser.DeclarationContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
