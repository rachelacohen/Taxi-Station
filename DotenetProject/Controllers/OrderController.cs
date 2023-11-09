using DotenetProject.Enitities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotenetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        DataContext context;
        public OrderController(DataContext data)
        {
            context = data;
        }
        // GET: api/<PassangerController>
        [HttpGet]
        public IEnumerable<Order> GetAll()
        {
            return context.orders;
        }

        // GET api/<PassangerController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOne(int id)
        {
            var v = context.orders.Find(x => x.Id == id);
            if (v == null)
                return NotFound();
            return v;

        }

        // POST api/<PassangerController>
        [HttpPost]
        public void Post([FromBody] Order o)
        {
            context.orders.Add(new Order(o.Source,o.Id,o.Destination,o.Order_time));
        }

        // PUT api/<PassangerController>/5
        [HttpPut("{id}")]
        public ActionResult<Order> Put([FromBody] Order o)
        {
            var v = context.orders.Find(x => x.Id == o.Id);
            if (v == null)
                return NotFound();
            v.Order_time.Equals(o.Order_time);
            return NoContent();
        }

        // DELETE api/<PassangerController>/5
        [HttpDelete("{id}")]
        public ActionResult<Order> Delete(int id)
        {
            var order = context.orders.Find(x => x.Id == id);
            if (order == null)
                return NotFound();
            context.orders.Remove(order);
            return NoContent();
        }
    }
}
