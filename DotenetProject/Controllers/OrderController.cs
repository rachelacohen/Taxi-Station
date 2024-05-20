
using AutoMapper;
using DotenetProject.Models;
using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solid.core.DTOs;

namespace DotenetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        // GET: api/<PassangerController>
        [HttpGet]
        public ActionResult GetAll()
        {
            var list=_orderService.GetOrders();
            return Ok(_mapper.Map<IEnumerable<OrderDto>>(list));

        }

        // GET api/<PassangerController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOne(int id)
        {
            return Ok(_mapper.Map<OrderDto>( _orderService.GetOrder(id)));

        }

        // POST api/<PassangerController>
        [HttpPost]
        public async Task Post([FromBody] OrderPostModel o)
        {
            var ocast = new Order { Source = o.Source, Destination = o.Destination, Order_time = o.Order_time, CustPhone=o.CustPhone, DriverId=o.DriverId };
           await _orderService.AddOrderAsync(ocast);
        }

        // PUT api/<PassangerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] OrderPostModel o)
        {
            var ocast = new Order { Source = o.Source, Destination = o.Destination, Order_time = o.Order_time, CustPhone=o.CustPhone, DriverId=o.DriverId };
            return await Task.Run(()=>Ok(_orderService.UpdateOrderAsync(id, ocast)));
        }

        // DELETE api/<PassangerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> Delete(int id)
        {
          await  _orderService.DeleteOrderAsync(id);
            return Ok();
        }
    }
}
