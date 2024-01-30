namespace DotenetProject.Solid.Core.Enitities
{
    public class Taxi
    {
        public int Id { get; set; }
        public bool IsAvailable { get; set; }

        public Driver Driver { get; set; }

    }
}
