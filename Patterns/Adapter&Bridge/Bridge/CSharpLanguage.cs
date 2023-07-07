namespace Bridge;
class CSharpLanguage : ILanguage
{
    public void Build() => Console.WriteLine("With compiler Roslyn we compire code in file exe");
    public void Execute()
    {
        Console.WriteLine("JIT compire the program binary code");
        Console.WriteLine("CLR execute compiring binary code");
    }
}
