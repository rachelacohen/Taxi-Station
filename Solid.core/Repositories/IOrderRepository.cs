using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Repositories
{
    public interface IOrderRepository
    {
        
        List<Order> GetOrders();

        Order GetById(int id);

         Task<Order> AddOrderAsync(Order o);

         Task<Order> UpdateOrderAsync(int id, Order o);
         Task DeleteOrderAsync(int id);
    }
}
