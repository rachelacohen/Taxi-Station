using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Repositories;
using DotenetProject.Solid.Core.Services;

namespace DotenetProject.Solid.Services
{
    public class TaxiService:ITaxiService
    {
        private readonly ITaxiRepository _TaxiRepository;

        public TaxiService(ITaxiRepository TaxiRepository)
        {
            _TaxiRepository = TaxiRepository;
        }

        public List<Taxi> GetTaxis()
        {
            return _TaxiRepository.GetTaxis();
        }

        public Taxi GetTaxi(int id)
        {
            return _TaxiRepository.GetById(id);
        }

        public async Task<Taxi> AddTaxiAsync(Taxi t)
        {
           return await _TaxiRepository.AddTaxiAsync(t);
        }

        public async Task<Taxi> UpdateTaxiAsync(int id, Taxi t)
        {
            return await (_TaxiRepository.UpdateTaxiAsync(id, t)); 
        }

        public async Task DeleteTaxiAsync(int id)
        {
          await  _TaxiRepository.DeleteTaxiAsync(id);
        }
    }
}
