namespace WebApiRepository.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}
