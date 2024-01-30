using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Repositories
{
    public interface ITaxiRepository
    {
        
        List<Taxi> GetTaxis();

        Taxi GetById(int id);

        Task<Taxi> AddTaxiAsync(Taxi t);

        Task<Taxi> UpdateTaxiAsync(int id, Taxi t);

        Task DeleteTaxiAsync(int id);
    }
}

