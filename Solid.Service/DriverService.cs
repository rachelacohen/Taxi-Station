
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

        public Driver AddDriver(Driver d)
        {
           return _DriverRepository.AddDriver(d);
        }

        public Driver UpdateDriver(int id, Driver d)
        {
          return _DriverRepository.UpdateDriver(id, d);   
        }

        public void DeleteDriver(int id)
        {
            _DriverRepository.DeleteDriver(id); 
        }
    }
}
