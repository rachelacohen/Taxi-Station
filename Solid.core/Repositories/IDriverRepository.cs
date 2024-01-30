using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Repositories
{
    public interface IDriverRepository
    {
        List<Driver> GetDrivers();

        Driver GetById(int id);

         Task<Driver> AddDriverAsync(Driver d);

         Task<Driver> UpdateDriverAsync(int id, Driver d);

         Task DeleteDriverAsync(int id);
    }
}
