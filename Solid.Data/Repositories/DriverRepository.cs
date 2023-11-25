using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Repositories;
using static DotenetProject.Solid.Data.Repositories.DriverRepository;

namespace DotenetProject.Solid.Data.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        private readonly DataContext _context;

        public DriverRepository(DataContext context)
        {
            _context = context;
        }

        public Driver AddDriver(Driver d)
        {
            _context.drivers.Add(d);
            return d;
        }

        public void DeleteDriver(int id)
        {
            _context.drivers.Remove(_context.drivers.Find(x => x.Id == id));
        }

        public Driver GetById(int id)
        {
            return _context.drivers.Find(d => d.Id == id);
        }

        public List<Driver> GetDrivers()
        {
            return _context.drivers;
        }

        public Driver UpdateDriver(int id, Driver d)
        {
            var updateDriver = _context.drivers.Find(d => d.Id == id);
            if (updateDriver != null)
            {
                updateDriver.Name = d.Name;
                return updateDriver;
            }
            return null;
        }

    }
}

