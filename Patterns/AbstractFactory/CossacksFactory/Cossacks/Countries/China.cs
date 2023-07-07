using Cossacks.FactoriesProducts;
using Cossacks.FactoriesProducts.China;
namespace Cossacks.Countries;
public class China : CountriesFactory
{
    public Hourses CreateHourses()
    {
        return new HoursesChina();
    }

    public Pehots CreatePehots()
    {
        return new PehotsChina();
    }

    public void Priority()
    {
        Console.WriteLine("China has the best weapons!");
    }
}