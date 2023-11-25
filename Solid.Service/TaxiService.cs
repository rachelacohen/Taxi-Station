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

        public Taxi AddTaxi(Taxi t)
        {
           return _TaxiRepository.AddTaxi(t);
        }

        public Taxi UpdateTaxi(int id, Taxi t)
        {
            return (_TaxiRepository.UpdateTaxi(id, t)); 
        }

        public void DeleteTaxi(int id)
        {
            _TaxiRepository.DeleteTaxi(id);
        }
    }
}
