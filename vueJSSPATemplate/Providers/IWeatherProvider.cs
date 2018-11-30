using System.Collections.Generic;
using vueJSSPATemplate.Models;

namespace vueJSSPATemplate.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
