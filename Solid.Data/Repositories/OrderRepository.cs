

using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DotenetProject.Solid.Data.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Order> AddOrderAsync(Order o)
        {
            _context.Orderrs.Add(o);
          await  _context.SaveChangesAsync();
            return o;
        }

        public async Task DeleteOrderAsync(int id)
        {
            _context.Orderrs.Remove(_context.Orderrs.ToList().Find(x => x.Id == id));
          await  _context.SaveChangesAsync();
        }

        public Order GetById(int id)
        {
            return _context.Orderrs.ToList().Find(o => o.Id == id);
        }

        public List<Order> GetOrders()
        {
            return _context.Orderrs.ToList();
        }

        public async Task<Order> UpdateOrderAsync(int id, Order o)
        {
            var updateOrder = _context.Orderrs.ToList().Find(o => o.Id == id);
            if (updateOrder != null)
            {
                updateOrder.Order_time = o.Order_time;
                updateOrder.Source = o.Source;
                updateOrder.Destination = o.Destination;
               await _context.SaveChangesAsync();
                return updateOrder;
            }
            return null;
        }
    }
}

