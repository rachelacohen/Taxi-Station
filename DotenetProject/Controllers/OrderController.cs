
using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotenetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/<PassangerController>
        [HttpGet]
        public IEnumerable<Order> GetAll()
        {
            return _orderService.GetOrders();
        }

        // GET api/<PassangerController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOne(int id)
        {
            return _orderService.GetOrder(id);

        }

        // POST api/<PassangerController>
        [HttpPost]
        public void Post([FromBody] Order o)
        {
            _orderService.AddOrder(o);
        }

        // PUT api/<PassangerController>/5
        [HttpPut("{id}")]
        public ActionResult<Order> Put(int id, [FromBody] Order o)
        {
            return Ok(_orderService.UpdateOrder(id, o));
        }

        // DELETE api/<PassangerController>/5
        [HttpDelete("{id}")]
        public ActionResult<Order> Delete(int id)
        {
            _orderService.DeleteOrder(id);
            return Ok();
        }
    }
}
