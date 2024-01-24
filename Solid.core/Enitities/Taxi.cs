namespace DotenetProject.Solid.Core.Enitities
{
    public class Taxi
    {
        public int Id { get; set; }
        public bool IsAvailable { get; set; }

        public Taxi(int id, bool isAvailable)
        {
            Id = id;
            IsAvailable = isAvailable;
        }

        public Driver Driver { get; set; }

        public Taxi() { }
    }
}
