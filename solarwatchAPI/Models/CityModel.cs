namespace solarwatchAPI.Models
{
    public class City
    {
        public City (string name, string country, string state, double lat, double lon)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            State = state;
            Lat = lat;
            Lon = lon;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }

    }
}
