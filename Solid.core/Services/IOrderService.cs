using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Services
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        Order GetOrder(int id);
        Task<Order> AddOrderAsync(Order order);

        Task<Order> UpdateOrderAsync(int id, Order order);

        Task DeleteOrderAsync(int id);
    }
}
