using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Weather.Data.Models;
public class ForecastHistory
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string CityName { get; set; } = null!;

    public byte[] Icon { get; set; }

    [DefaultValue(0)]
    public int Temp { get; set; }

    [DefaultValue(0)]
    public int Humidity { get; set; }

    [DefaultValue(0)]
    public int FeelsLike { get; set; }

    [DefaultValue(0)]
    public int WindSpeed { get; set; }

    [DefaultValue(0)]
    public int Pressure { get; set; }
}
