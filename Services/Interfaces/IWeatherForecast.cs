namespace WebApiRepository.Services.Interfaces
{
    public interface IWeatherForecast
    {
        // inteface is like contact, whosoever will inherit interface needs to implement the  
        IEnumerable<WeatherForecast> Get();
    }
}
