using FormationAspMvcApp.Models;

namespace FormationAspMvcApp.Data
{
    public class Repository : IRepository
    {
        List<Restaurant> restaurants = new List<Restaurant>(){

            new Restaurant
            {
                Id = 1,
                Name = "restau A",
                Address = "Rabat",
                Description = "open",
                Cuisins = new List<Cuisins>
                {
                    new Cuisins{Id = 1, Name = "cuisine 1"},
                    new Cuisins{Id = 2, Name = "cuisine 2"},
                }
            }
                    //new Restaurant(1, "PizzaHut","Rabat","Open",
                    //    new Cuisins),
                  //new Restaurant(2, "KFC","Rabat","Open"),
                  //new Restaurant(3, "Suchi","casa","Open"),
                  //new Restaurant(4, "MacDonalds","Tanger","Open"),

                };


        private readonly List<Restaurant> _restaurants = new List<Restaurant>();




        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public Restaurant GetById(int id)
        {
            return _restaurants.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Restaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void Delete(Restaurant restaurant)
        {

            _restaurants.Remove(restaurant);
        }

       

        public void Update(Restaurant restaurant)
        {
            Restaurant Newrestaurant = _restaurants.Find(x => x.Id==restaurant.Id);
            Newrestaurant.Id = restaurant.Id;
            Newrestaurant.Address = restaurant.Address;
            Newrestaurant.Name = restaurant.Name;
            Newrestaurant.Description = restaurant.Description;
        }
    }


}
