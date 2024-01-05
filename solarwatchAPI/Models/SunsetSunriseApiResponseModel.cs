namespace solarwatchAPI.Models
{
    public class SunsetSunriseApiResponse
    {
        public SunsetSunriseApiResponse(string name, DateTime sunrise, DateTime sunset)
        {
            Id = Guid.NewGuid();
            Name = name;
            Sunrise = sunrise;
            Sunset = sunset;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }

    }
    public record ApiResult(SunsetSunriseApiResponse results);
}
