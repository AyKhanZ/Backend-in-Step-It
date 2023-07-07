using Cossacks.Countries;
namespace MyNamespace;
public class Program
{
    public static void Main()
    {
        CountriesFactory factory;
        factory = new Azerbaijan();
        factory.CreatePehots();
        factory.Priority();
    }
}