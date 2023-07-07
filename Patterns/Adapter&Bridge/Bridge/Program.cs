using Bridge;
namespace Patters;
public class Program
{
    public static void Main()
    {
        // с++ programmer
        Programmer freelancer = new FreelanceProgrammer(new CPlusPlusLanguage());
        freelancer.DoWork();
        freelancer.EarnMoney();

        // c# programmer
        freelancer.Language = new CSharpLanguage();
        freelancer.DoWork();
        freelancer.EarnMoney();
    }
}


