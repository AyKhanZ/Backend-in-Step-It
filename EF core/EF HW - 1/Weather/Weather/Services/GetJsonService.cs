using System;
using System.Net;
using Weather.Models;
namespace Weather.Services;
public class GetJsonService
{
    private WebClient webClient = new();
    private WeatherSearchModel searchModel;


    public string? GetWeatherJson(string? cityName)
    {
        if (cityName != null)
        {
            searchModel = new(cityName);
            try
            {
                string? json = webClient.DownloadString(searchModel.ToString());
                return json;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        throw new NullReferenceException("City is null");
    }
}