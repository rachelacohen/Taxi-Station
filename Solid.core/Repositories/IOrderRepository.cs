using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Repositories
{
    public interface IOrderRepository
    {
        
        List<Order> GetOrders();

        Order GetById(int id);

        Order AddOrder(Order order);

        Order UpdateOrder(int id, Order order);

        void DeleteOrder(int id);
    }
}
