namespace DotenetProject.Solid.Core.Enitities
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Taxi Taxi { get; set; }
        public int TaxiId { get; set; }
        public List<Order> Orders { get; set; } 

    }
}
