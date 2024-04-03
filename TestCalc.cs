

using Antlr4.Runtime;

class TestCalc
{
    static void Main()
    {
        // Read from stdin
        var input = new AntlrInputStream(Console.OpenStandardInput());
        var lexer = new CalcLexer(input);
        var tokens = new CommonTokenStream(lexer);
        var parser = new CalcParser(tokens);
        var tree = parser.expr(); // parse starting at the 'expr' rule

        Console.WriteLine(tree.ToStringTree(parser));
    }
}
