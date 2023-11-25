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

    }
}
