using solarwatchAPI.DatabaseConnector;
using solarwatchAPI.Models;

namespace solarwatchAPI.Repository
{
    public class CitiesRepository : ICityRepository
    {
        public IEnumerable<City> GetAll ()
        {
            using var dbContext = new CityContext();
            return dbContext.cities.ToList();
        }

        public City? GetByName (string name)
        {
            using var dbContext = new CityContext();
            return dbContext.cities.FirstOrDefault(c => c.Name == name);
        }

        public void Add (City city)
        {
            using var dbContext = new CityContext();
            dbContext.Add(city);
            dbContext.SaveChanges();
        }

        public void Delete (City city)
        {
            using var dbContext = new CityContext();
            dbContext.Remove(city);
            dbContext.SaveChanges();
        }

        public void Update (City city)
        {
            using var dbContext = new CityContext();
            dbContext.Update(city);
            dbContext.SaveChanges();
        }
    }

    public interface ICityRepository
    {
        IEnumerable<City> GetAll ();
        City? GetByName (string name);

        void Add (City city);
        void Delete (City city);
        void Update (City city);
    }

}
