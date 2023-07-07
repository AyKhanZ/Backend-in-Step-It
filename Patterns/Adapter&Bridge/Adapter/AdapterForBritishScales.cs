namespace Adapter;
public class AdapterForBritishScales : BritishScales, IScales
{
    public AdapterForBritishScales(float cw) : base(cw) { }
    float IScales.GetWeight()
    {
        return ((float)(base.GetWeight() * 0.453));
    }
    void IScales.Adjust()
    {
        Console.WriteLine("British Adjust in adapter!");
    }
}