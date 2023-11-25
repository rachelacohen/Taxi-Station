using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Repositories
{
    public interface ITaxiRepository
    {
        
        List<Taxi> GetTaxis();

        Taxi GetById(int id);

        Taxi AddTaxi(Taxi order);

        Taxi UpdateTaxi(int id, Taxi order);

        void DeleteTaxi(int id);
    }
}

