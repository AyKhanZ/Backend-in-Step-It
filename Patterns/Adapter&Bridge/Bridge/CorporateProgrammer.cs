namespace Bridge;
class CorporateProgrammer : Programmer
{
    public CorporateProgrammer(ILanguage lang) : base(lang) { }
    public override void EarnMoney() => Console.WriteLine("Gets salary by the end of the month!");
}