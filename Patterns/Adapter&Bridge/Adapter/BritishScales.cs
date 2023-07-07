namespace Adapter;
public class BritishScales
{
    private float CurrentWeight;
    public BritishScales(float cw)
    {
        CurrentWeight = cw;
    }
    public void Adjust()
    {
        Console.WriteLine("British adjust!");
    }

    public float GetWeight()
    {
        return CurrentWeight;
    }
}
