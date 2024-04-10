using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;

public class TypeCheckingVisitor : CalcBaseVisitor<object>
{
    private SymbolTable symbolTable = new SymbolTable();

    public override object VisitDecl([NotNull] CalcParser.DeclContext context)
    {
        // var id = context.ID().GetText();
        // var type = context.DATA_TYPE().GetText();
        // symbolTable.Define(id, type);
        //             Console.WriteLine($"Error: Variable '{id}' not declared.");

        return null;
    }

    public override object VisitAssignExpr([NotNull] CalcParser.AssignExprContext context)
    {
        // var id = context.ID().GetText();
        // var type = symbolTable.GetType(id);
        // // Here, you would also need to determine the type of the right-hand side expression
        // // For simplicity, let's assume it's always correct. In a real scenario, you'd recursively visit
        // // the expression, determine its type, and compare.
        //     Console.WriteLine($"Error: Variable '{id}' not declared.");

        // // Example check (simplified)
        // if (type is not null) // Variable not declared
        // {
        //     Console.WriteLine($"Error: Variable '{id}' not declared.");
        // }

        return base.VisitAssignExpr(context);
    }

    // Implement other necessary visit methods for type checking
}
