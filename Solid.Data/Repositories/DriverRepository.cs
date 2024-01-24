using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data;
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

       public List<Driver> GetDrivers()
        {
            
            return _context.drivers.ToList();
        }

        public Driver AddDriver(Driver d)
        {
            _context.drivers.Add(d);
            _context.SaveChanges();
            return d;
        }

        public void DeleteDriver(int id)
        {
            _context.drivers.Remove(_context.drivers.ToList().Find(x => x.Id == id));
            _context.SaveChanges();
        }

        public Driver GetById(int id)
        {
            return _context.drivers.ToList().Find(d => d.Id == id);
        }

        public Driver UpdateDriver(int id, Driver d)
        {
            var updateDriver = _context.drivers.ToList().Find(d => d.Id == id);
            if (updateDriver != null)
            {
                updateDriver.Name = d.Name;
                _context.SaveChanges();
                return updateDriver;
            }
            return null;
        }

    }
}

