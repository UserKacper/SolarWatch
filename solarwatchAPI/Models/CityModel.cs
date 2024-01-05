namespace solarwatchAPI.Models
{
    public class City
    {
        public City (string name, string country, string state, decimal latitude, decimal longitude)
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
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

    }
}
