using DotenetProject.Solid.Core.Enitities;

namespace DotenetProject.Solid.Core.Services
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        Order GetOrder(int id);
        Order AddOrder(Order order);

        Order UpdateOrder(int id, Order order);

        void DeleteOrder(int id);
    }
}
