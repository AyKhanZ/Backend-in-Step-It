using Cossacks.FactoriesProducts;
using Cossacks.FactoriesProducts.Azerbaijan;
namespace Cossacks.Countries;
public class Azerbaijan : CountriesFactory
{
    public Hourses CreateHourses()
    {
        return new HoursesAzerbaijan();
    }

    public Pehots CreatePehots()
    {
        return new PehotsAzerbaijan();
    }

    public void Priority()
    {
        Console.WriteLine("Azerbaijan has the best tanks and planes!");
    }
}