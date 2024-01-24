

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

        public Order AddOrder(Order o)
        {
            _context.orders.Add(o);
            _context.SaveChanges();
            return o;
        }

        public void DeleteOrder(int id)
        {
            _context.orders.Remove(_context.orders.ToList().Find(x => x.Id == id));
            _context.SaveChanges();
        }

        public Order GetById(int id)
        {
            return _context.orders.ToList().Find(o => o.Id == id);
        }

        public List<Order> GetOrders()
        {
            return _context.orders.ToList();
        }

        public Order UpdateOrder(int id, Order o)
        {
            var updateOrder = _context.orders.ToList().Find(o => o.Id == id);
            if (updateOrder != null)
            {
                updateOrder.Order_time = o.Order_time;
                updateOrder.Source = o.Source;
                updateOrder.Destination = o.Destination;
                _context.SaveChanges();
                return updateOrder;
            }
            return null;
        }
    }
}

