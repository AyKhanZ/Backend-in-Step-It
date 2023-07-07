namespace Bridge;
class CPlusPlusLanguage : ILanguage
{
    public void Build() => Console.WriteLine("With C++ we compiliring code in binary-code");
    public void Execute() => Console.WriteLine("Executing program file");
}