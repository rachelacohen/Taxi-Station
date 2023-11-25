using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Services
{
    public interface IDriverService
    {
        List<Driver> GetDrivers();
        Driver GetDriver(int id);
        Driver AddDriver(Driver user);

        Driver UpdateDriver(int id, Driver user);

        void DeleteDriver(int id);
    }
}
