namespace DotenetProject.Solid.Core.Enitities
{
    public class Order
    {
        public string Source { get; set; }
        public int Id { get; set; }
        public string Destination { get; set; }
        public DateTime Order_time { get; set; }
        public string CustPhone { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
