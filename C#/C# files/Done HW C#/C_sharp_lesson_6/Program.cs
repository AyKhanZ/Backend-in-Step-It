using C_sharp_lesson_6;
using System;
using System.Net;
using System.Runtime.ExceptionServices; 
using System.Text.Json; 



namespace Program
{
    public class Program
    {
        public static void Main()
        {
            FirstForecastService first = new();

            IForecastServece service = first;


            var result = service.GetForecastByCity("Baku");

            var weather = JsonSerializer.Deserialize<Forecast>(result) ;

            Console.WriteLine(weather.main.temp);

             
        }
    }
}