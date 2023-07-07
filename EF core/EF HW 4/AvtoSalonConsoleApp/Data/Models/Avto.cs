namespace AvtoSalonConsoleApp.Data.Models;
public class Avto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Mark { get; set; } = null!;
    public int AvtosalonId { get; set; }
    public Avtosalon Avtosalon { get; set; }
}