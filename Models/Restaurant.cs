namespace FormationAspMvcApp.Models
{
    public class Restaurant
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Address { get; set; }

        public List<Cuisins>? Cuisins { get; set; }


        public Restaurant() { }

        public Restaurant(int id, string name, string description, string address, List<Cuisins> cuisins)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Address = address;
            this.Cuisins = cuisins;

        }
    }
 




}
