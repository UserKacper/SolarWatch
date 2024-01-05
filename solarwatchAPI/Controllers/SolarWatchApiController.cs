using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using solarwatchAPI.Models;

namespace solarwatchAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SolarWatchApiController : ControllerBase
{
    HttpClient _client;
    public SolarWatchApiController (IHttpClientFactory httpClientFactory)
    {
        _client = httpClientFactory.CreateClient();
    }

    private async Task<City> GetCityFromGeocodingApi (string cityName)
    {
        const string ApiKey = "f880893dcbc259fd0152ec19e2ecf5ee";
        string ApiUrl = $"http://api.openweathermap.org/geo/1.0/direct?q={cityName}&limit={1}&appid={ApiKey}";

        var response = await _client.GetAsync(ApiUrl);
        response.EnsureSuccessStatusCode();
        var responseBody =await response.Content.ReadAsStringAsync();
        var city = JsonConvert.DeserializeObject<List<City>>(responseBody).FirstOrDefault();
        Console.WriteLine(city.Id);
        return city;
    }

    [HttpGet]
    public async Task<SunsetSunriseApiResponse> GetTodaysSunsetSunriseTimes ([FromQuery] string cityName, [FromQuery] DateOnly date)
    {
        var GeocodingApiResult =await GetCityFromGeocodingApi(cityName);
        var lon = GeocodingApiResult.Longitude;
        var lat = GeocodingApiResult.Latitude;
        var name = GeocodingApiResult.Name;

        var ApiUrl = $"https://api.sunrise-sunset.org/json?lat={lat}&lng={lon}&date={date}";

        var response =await _client.GetAsync(ApiUrl);
        response.EnsureSuccessStatusCode();
        var responseBody =await response.Content.ReadAsStringAsync();
        var sunsetSunriseApi = JsonConvert.DeserializeObject<ApiResult>(responseBody);
        var result = new SunsetSunriseApiResponse(name, sunsetSunriseApi.results.Sunrise, sunsetSunriseApi.results.Sunset);
        return result;
    }

}
