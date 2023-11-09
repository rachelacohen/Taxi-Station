using DotenetProject.Enitities;

namespace DotenetProject
{
    public class DataContext
    {
        public List<Order> orders { get; set; }
        public List<Taxi> taxies { get; set; }
        public List<Driver> drivers { get; set; }
        public DataContext()
        {
            orders = new List<Order>(); 
            taxies = new List<Taxi>();
            drivers = new List<Driver>();
        }
    }
}
