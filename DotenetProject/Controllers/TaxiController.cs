
using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace DotenetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxiController : ControllerBase
    {

        private readonly ITaxiService _taxiService;

        public TaxiController(ITaxiService taxiService)
        {
            _taxiService = taxiService;
        }


        // GET: api/<TaxiController>
        [HttpGet]
        public IEnumerable<Taxi> Get()
        {
            return _taxiService.GetTaxis();
        }

        // GET api/<TaxiController>/5
        [HttpGet("{id}")]
        public ActionResult<Taxi> Get(int id)
        {
            return _taxiService.GetTaxi(id);
        }

        // POST api/<TaxiController>
        [HttpPost]
        public void Post([FromBody] Taxi t)
        {
            _taxiService.AddTaxi(t);
        }


        // PUT api/<TaxiController>/5
        [HttpPut("{id}")]
        public ActionResult<Taxi> Put(int id, [FromBody] Taxi t)
        {
            return Ok(_taxiService.UpdateTaxi(id, t));
        }

        // DELETE api/<TaxiController>/5
        [HttpDelete("{id}")]
        public ActionResult<Taxi> Delete(int id)
        {
            _taxiService.DeleteTaxi(id);
            return Ok();
        }
    }
}
