namespace DotenetProject.Solid.Core.Enitities
{
    public class Order
    {
        public string Source { get; set; }
        public int Id { get; set; }
        public string Destination { get; set; }
        public DateTime Order_time { get; set; }

        public Order(string source, int id, string destination, DateTime order_time)
        {
            Source = source;
            Id = id;
            Destination = destination;
            Order_time = order_time;
        }
        public Driver Driver { get; set; }
        public Order() { }
    }
}
