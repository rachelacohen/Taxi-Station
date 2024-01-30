
using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Repositories;
using DotenetProject.Solid.Core.Services;

using static DotenetProject.Solid.Services.DriverService;

namespace DotenetProject.Solid.Services
{
    public class DriverService : IDriverService
    {

        private readonly IDriverRepository _DriverRepository;

        public DriverService(IDriverRepository DriverRepository)
        {
            _DriverRepository = DriverRepository;
        }

        public List<Driver> GetDrivers()
        {
            return _DriverRepository.GetDrivers();
        }

        public Driver GetDriver(int id)
        {
            return _DriverRepository.GetById(id);
        }

        public async Task<Driver> AddDriverAsync(Driver d)
        {
           return await _DriverRepository.AddDriverAsync(d);
        }

        public async Task<Driver> UpdateDriverAsync(int id, Driver d)
        {
          return await _DriverRepository.UpdateDriverAsync(id, d);   
        }

        public async Task DeleteDriverAsync(int id)
        {
           await _DriverRepository.DeleteDriverAsync(id); 
        }
    }
}
