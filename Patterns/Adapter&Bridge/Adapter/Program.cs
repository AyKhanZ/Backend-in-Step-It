using Adapter;
namespace Patters;
class Program
{
    public static void Main()
    {
        IScales Rscales = new RussianScales(55.0f);
        IScales Bscales = new AdapterForBritishScales(55.0f);

        Console.WriteLine(Rscales.GetWeight());
        Rscales.Adjust();
        Console.WriteLine(Bscales.GetWeight());
        Bscales.Adjust();
    }
}