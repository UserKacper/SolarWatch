using solarwatchAPI.DatabaseConnector;
using solarwatchAPI.Models;

namespace solarwatchAPI.Repository
{
    public class CitiesRepository : ICityRepository
    {
        public async Task<IEnumerable<City>> GetAll ()
        {
            await using var dbContext = new CityContext();
            return dbContext.cities.ToList();
        }

        public async Task<City?> GetByName (string name)
        {
            await using var dbContext = new CityContext();
            return dbContext.cities.FirstOrDefault(c => c.Name == name);
        }

        public async Task Add (City city)
        {
            await using var dbContext = new CityContext();
            dbContext.Add(city);
            dbContext.SaveChanges();
        }

        public async Task Delete (City city)
        {
            await using var dbContext = new CityContext();
            dbContext.Remove(city);
            dbContext.SaveChanges();
        }

        public async Task Update (City city)
        {
            await using var dbContext = new CityContext();
            dbContext.Update(city);
            dbContext.SaveChanges();
        }
    }

    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetAll ();
        Task<City?> GetByName (string name);

        Task Add (City city);
        Task Delete (City city);
        Task Update (City city);
    }

}
