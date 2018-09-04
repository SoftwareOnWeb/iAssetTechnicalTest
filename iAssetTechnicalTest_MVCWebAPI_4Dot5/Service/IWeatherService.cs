using iAssetTechnicalTest_MVCWebAPI_4Dot5.Models;

namespace iAssetTechnicalTest_MVCWebAPI_4Dot5.Service
{
    public interface IWeatherService
    {
        WeatherDataVIewModel GetWeatherByCityAndCountry(WeatherFilter weatherOptions);
    }
}