

using Antlr4.Runtime;

class TestCalc
{
    public static void Main()
    {
        // Read from stdin
        var input = new AntlrInputStream("1+23");
        var lexer = new CalcLexer(input);
        var tokens = new CommonTokenStream(lexer);
        var parser = new CalcParser(tokens);
        var tree = parser.expr(); // parse starting at the 'expr' rule

        Console.WriteLine(tree.ToStringTree(parser));
    }
}
