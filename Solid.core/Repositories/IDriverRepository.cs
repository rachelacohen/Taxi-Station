using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Repositories
{
    public interface IDriverRepository
    {
        List<Driver> GetDrivers();

        Driver GetById(int id);

        Driver AddDriver(Driver user);

        Driver UpdateDriver(int id, Driver user);

        void DeleteDriver(int id);
    }
}
