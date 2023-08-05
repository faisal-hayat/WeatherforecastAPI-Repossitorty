# Weather Forecast Using Repository Pattern

--- ---

## Repositiry Pattern

- The repository pattern is a design pattern that isolates the data layer from the rest of the app

--- ---

## Repository Pattern

- Repository pattern works as a service
- Needs to be registered in **_program.cs_**

```C#
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();
```

--- ---