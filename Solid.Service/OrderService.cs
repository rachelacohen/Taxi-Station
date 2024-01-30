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

        public async Task<Order> AddOrderAsync(Order order)
        {
            return await _OrderRepository.AddOrderAsync(order);
        }

        public async Task<Order> UpdateOrderAsync(int id, Order order)
        {
            return await _OrderRepository.UpdateOrderAsync(id,order);
        }

        public async Task DeleteOrderAsync(int id)
        {
            await _OrderRepository.DeleteOrderAsync(id);
        }
    }
}
