namespace DotenetProject.Models
{
    public class OrderPostModel
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public string CustPhone { get; set; }
        public DateTime Order_time { get; set; }

        public int DriverId { get; set; }
    }
}
