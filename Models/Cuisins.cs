namespace FormationAspMvcApp.Models
{
    public class Cuisins
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        //public Cuisins(int id, string name) {
            
        //    Id = id;
        //    Name = name;

        //}

    }
}
