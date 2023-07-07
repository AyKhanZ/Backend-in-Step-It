using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lesson_6
{
    internal class FirstForecastService:IForecastServece
    {
        private string _key = "941a31fdf3ad7a5bb031128e5f2943ba";
        private string _url = @"https://api.openweathermap.org/data/2.5/weather?";
        WebClient client_ = new();
        public string GetForecastByCity(string city) {

            string link = $"{_url}q={city}&appid={_key}";
            var result = client_.DownloadString(link);
            return result;
        }
    }
}
