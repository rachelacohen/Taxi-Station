using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Services
{
    public interface ITaxiService
    {
        List<Taxi> GetTaxis();
        Taxi GetTaxi(int id);
        Taxi AddTaxi(Taxi order);

        Taxi UpdateTaxi(int id, Taxi order);

        void DeleteTaxi(int id);
    }
}
