namespace Weather.Models;
public class WeatherSearchModel
{
    //https://api.openweathermap.org/data/2.5/weather?q=Baku&appid=5191fee1957155f779bfd029a4a97e18

    private string Link = @"https://api.openweathermap.org/data/2.5/weather?q=";
    private string AppId = "5191fee1957155f779bfd029a4a97e18";
    private string CityName;

    public WeatherSearchModel(string cityName)
    {
        CityName = cityName;
    }

    public override string ToString()
    {
        return $"{Link}{CityName}&appid={AppId}&units=metric";
    }
}