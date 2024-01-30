using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DotenetProject.Solid.Data.Repositories
{
    public class TaxiRepository:ITaxiRepository
    {
        private readonly DataContext _context;

        public TaxiRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Taxi> AddTaxiAsync(Taxi t)
        {

            _context.Taxiies.ToList().Add(t);
          await _context.SaveChangesAsync();
            return t;
        }

        public async Task DeleteTaxiAsync(int id)
        {
            _context.Taxiies.Remove(_context.Taxiies.ToList().Find(t => t.Id == id));
           await _context.SaveChangesAsync();
        }

        public Taxi GetById(int id)
        {
            return _context.Taxiies.ToList().Find(o => o.Id == id);
        }

        public List<Taxi> GetTaxis()
        {
            return _context.Taxiies.ToList();
        }

        public async Task<Taxi> UpdateTaxiAsync(int id, Taxi t)
        {
            var updateTaxi = _context.Taxiies.ToList().Find(t => t.Id == id);
            if (updateTaxi != null)
            {
                updateTaxi.IsAvailable = t.IsAvailable;
              await  _context.SaveChangesAsync();
                return updateTaxi;
            }
            return null;
        }
    }
}
