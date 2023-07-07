using Cossacks.FactoriesProducts;
using Cossacks.FactoriesProducts.Russian;
namespace Cossacks.Countries;
public class Russian : CountriesFactory
{
    public Hourses CreateHourses()
    {
        return new HoursesRussian();
    }

    public Pehots CreatePehots()
    {
        return new PehotsRussian();
    }

    public void Priority()
    {
        Console.WriteLine("Russian has the biggest ships!");
    }
}