using Cossacks.FactoriesProducts;
using Cossacks.FactoriesProducts.France;
namespace Cossacks.Countries;
public class France : CountriesFactory
{
    public Hourses CreateHourses()
    {
        return new HoursesFrance();
    }

    public Pehots CreatePehots()
    {
        return new PehotsFrance();
    }

    public void Priority()
    {
        Console.WriteLine("France has the fastest hourses!");
    }
}