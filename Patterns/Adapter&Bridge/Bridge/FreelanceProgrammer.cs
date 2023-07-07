namespace Bridge;
class FreelanceProgrammer : Programmer
{
    public FreelanceProgrammer(ILanguage lang) : base(lang) { }
    public override void EarnMoney() => Console.WriteLine("Gets money for order!");  
}