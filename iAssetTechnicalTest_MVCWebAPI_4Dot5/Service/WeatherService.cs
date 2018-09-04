using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using iAssetTechnicalTest_MVCWebAPI_4Dot5.Models;
namespace iAssetTechnicalTest_MVCWebAPI_4Dot5.Service
{
    public class WeatherService : IWeatherService
    {
 
        public WeatherDataVIewModel GetWeatherByCityAndCountry(WeatherFilter weatherOptions)
        {
            Uri uri = new Uri("https://api.openweathermap.org/data/2.5/weather?q=" + weatherOptions.City + "," + weatherOptions.Country + "&appid=" + "6b3b6d4ebd445dcfc5f4336c96abe06c");
            WeatherData weatherData = null;
            using (var client = new HttpClient())
            {

                var responseTask = client.GetAsync(uri);
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<WeatherData>();
                    readTask.Wait();

                    weatherData = readTask.Result;
                }
                else 
                {
                    return null;
                   // ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            WeatherDataVIewModel weatherDataVIewModel = new WeatherDataVIewModel()
            {
                Country=weatherData.sys.country,
                City=weatherData.name,
                Clouds = weatherData.clouds,
                Humidity = weatherData.main.humidity,
                Pressure = weatherData.main.pressure,
                Temprature = weatherData.main.temp,
                Visibility = weatherData.visibility,
                Wind = weatherData.wind

            };

            return weatherDataVIewModel;
        }
    }
}