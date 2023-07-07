using System.Collections.Generic;
namespace AvtoSalonConsoleApp.Data.Models;
public class Avtosalon
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<Avto> Avtoes { get; set; }
}