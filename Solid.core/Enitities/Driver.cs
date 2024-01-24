namespace DotenetProject.Solid.Core.Enitities
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Driver(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Taxi Taxi { get; set; }
        public int TaxiId { get; set; }
        public List<Order> Orders { get; set; }
        public Driver() { }

    }
}
