namespace solarwatchAPI.Models
{
    public class City
    {
        public City (string name, string country, string state, double latitude, double longitude)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            State = state;
            Latitude = latitude;
            Longitude = longitude;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
