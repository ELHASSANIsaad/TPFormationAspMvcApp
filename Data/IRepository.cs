using FormationAspMvcApp.Models;

namespace FormationAspMvcApp.Data
{
    public interface IRepository
    {

        IEnumerable<Restaurant> GetAll();
        Restaurant GetById(int id);
        void Add(Restaurant customer);
        void Update(Restaurant customer);
        void Delete(Restaurant customer);
    }
}
