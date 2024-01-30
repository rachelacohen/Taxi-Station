using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Services
{
    public interface IDriverService
    {
        List<Driver> GetDrivers();
        Driver GetDriver(int id);
        Task<Driver> AddDriverAsync(Driver d);

        Task<Driver> UpdateDriverAsync(int id, Driver user);

        Task DeleteDriverAsync(int id);
    }
}
