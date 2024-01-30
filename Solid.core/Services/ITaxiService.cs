using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Services
{
    public interface ITaxiService
    {
        List<Taxi> GetTaxis();
        Taxi GetTaxi(int id);
        Task<Taxi> AddTaxiAsync(Taxi t);

        Task<Taxi> UpdateTaxiAsync(int id, Taxi t);

        Task DeleteTaxiAsync(int id);
    }
}
