using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;

public class TypeCheckingVisitor : CalcBaseVisitor<object>
{
    private SymbolTable symbolTable = new SymbolTable();

    bool IsNumber(string input)
    {
        return int.TryParse(input, out _);
    }
    bool IsBoolean(string input)
    {
        return bool.TryParse(input, out _);
    }
   public override object VisitDecl([NotNull] CalcParser.DeclContext context)
    {
        var id = context.ID().GetText();
        var declaredType = context.DATA_TYPE().GetText();
        var valueToken = context.GetChild(4) as Antlr4.Runtime.Tree.ITerminalNode;
        var sdasd = context.GetChild(4).GetText();
        var lineNumber = valueToken.Symbol.Line; // Get the line number

        if (!IsNumber(sdasd) && declaredType.Equals("int"))
        {
            Console.WriteLine($"Error: Type mismatch. Cannot assign {sdasd} to {declaredType} for variable '{id}' at line {lineNumber}.");
            return null;
        }

        if (!IsBoolean(sdasd) && declaredType.Equals("bool"))
        {
            Console.WriteLine($"Error: Type mismatch. Cannot assign {sdasd} to {declaredType} for variable '{id}' at line {lineNumber}.");
            return null;
        }
        
    
    
    
        symbolTable.Define(id, declaredType);
        Console.WriteLine($"{declaredType} {id}");
    
        return null;
    }

    //public override object VisitAssignExpr([NotNull] CalcParser.AssignExprContext context)
    //{
    //    var id = context.ID().GetText();
    //    var declaredType = symbolTable.GetType(id);
    //    
    //    if (declaredType is null) // If variable is not declared
    //    {
    //        Console.WriteLine($"Error: Variable '{id}' not declared.");
    //        return null; // Skip further checks if the variable is not declared
    //    }
//
    //    var exprType = Visit(context.expr()); // Determine the type of the right-hand side expression
//
    //    if (!declaredType.Equals(exprType))
    //    {
    //        Console.WriteLine($"Error: Type mismatch. Cannot assign {exprType} to {declaredType}.");
    //    }
//
    //    return base.VisitAssignExpr(context);
    //}


    // Visits binary expressions - simplified handling
    public override object VisitExpr([NotNull] CalcParser.ExprContext context)
    {
        // For simplicity, assuming all binary operations on integers result in integers
        // You would need more complex logic here to handle type mismatches and operations involving different types
        return "int";
    }

    // Implement other necessary visit methods for type checking
}
