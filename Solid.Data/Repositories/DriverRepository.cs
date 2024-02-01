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

            return _context.Driivers.ToList();
        }

        public async Task<Driver> AddDriverAsync(Driver d)
        {
            _context.Driivers.Add(d);
            await _context.SaveChangesAsync();
            return d;
        }

        public async Task DeleteDriverAsync(int id)
        {
            _context.Driivers.Remove(_context.Driivers.ToList().Find(x => x.Id == id));
          await  _context.SaveChangesAsync();
        }

        public Driver GetById(int id)
        {
            return _context.Driivers.ToList().Find(d => d.Id == id);
        }

        public async Task<Driver> UpdateDriverAsync(int id, Driver d)
        {
            var updateDriver = _context.Driivers.ToList().Find(d => d.Id == id);
            if (updateDriver != null)
            {
                updateDriver.Name = d.Name;
               await _context.SaveChangesAsync();
                return updateDriver;
            }
            return null;
        }

    }
}

