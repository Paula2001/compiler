public class SymbolTable
{
    private Dictionary<string, string> symbols = new Dictionary<string, string>();

    public void Define(string name, string type)
    {
        symbols[name] = type;
    }

    public string GetType(string name)
    {
        symbols.TryGetValue(name, out string type);
        return type;
    }
}
