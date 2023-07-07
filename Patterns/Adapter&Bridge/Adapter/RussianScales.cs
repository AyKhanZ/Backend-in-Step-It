namespace Adapter;
public class RussianScales : IScales
{
    private float CurrentWeight;
    public RussianScales(float cw)
    {
        CurrentWeight = cw;
    }
    public void Adjust()
    {
        Console.WriteLine("Russian Adjust!");
    }
    public float GetWeight()
    {
        return CurrentWeight;
    }
}