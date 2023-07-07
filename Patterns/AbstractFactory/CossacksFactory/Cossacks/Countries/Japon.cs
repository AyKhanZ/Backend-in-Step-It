using Cossacks.FactoriesProducts;
using Cossacks.FactoriesProducts.Japon;
namespace Cossacks.Countries;
public class Japon : CountriesFactory
{
    public Hourses CreateHourses()
    {
        return new HoursesJapon();
    }

    public Pehots CreatePehots()
    {
        return new PehotsJapon();
    }

    public void Priority()
    {
        Console.WriteLine("Japon has the biggest army!");
    }
}