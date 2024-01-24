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

        public Taxi AddTaxi(Taxi t)
        {
            _context.taxies.Add(t);
            return t;
        }

        public void DeleteTaxi(int id)
        {
            _context.taxies.Remove(_context.taxies.ToList().Find(t => t.Id == id));
            _context.SaveChanges();
        }

        public Taxi GetById(int id)
        {
            return _context.taxies.ToList().Find(o => o.Id == id);
        }

        public List<Taxi> GetTaxis()
        {
            return _context.taxies.ToList();
        }

        public Taxi UpdateTaxi(int id, Taxi t)
        {
            var updateTaxi = _context.taxies.ToList().Find(t => t.Id == id);
            if (updateTaxi != null)
            {
                updateTaxi.IsAvailable = t.IsAvailable;
                _context.SaveChanges();
                return updateTaxi;
            }
            return null;
        }
    }
}
