using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Repositories;
using DotenetProject.Solid.Core.Services;


namespace DotenetProject.Solid.Services
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }

        public List<Order> GetOrders()
        {
            return _OrderRepository.GetOrders();
        }

        public Order GetOrder(int id)
        {
            return _OrderRepository.GetById(id);
        }

        public Order AddOrder(Order order)
        {
            return _OrderRepository.AddOrder(order);
        }

        public Order UpdateOrder(int id, Order order)
        {
            return _OrderRepository.UpdateOrder(id,order);
        }

        public void DeleteOrder(int id)
        {
            _OrderRepository.DeleteOrder(id);
        }
    }
}
