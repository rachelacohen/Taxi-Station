using DotenetProject.Enitities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace DotenetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxiController : ControllerBase
    {

        DataContext context;
        public TaxiController(DataContext data)
        {
            context = data;
        }

        // GET: api/<TaxiController>
        [HttpGet]
        public IEnumerable<Taxi> Get()
        {
            return context.taxies;
        }

        // GET api/<TaxiController>/5
        [HttpGet("{id}")]
        public ActionResult<Taxi> Get(int id)
        {
            var v = context.taxies.Find(x => x.Id == id);
            if (v == null)
                return NotFound();
            return v;
        }

        // POST api/<TaxiController>
        [HttpPost]
        public void Post([FromBody] Taxi d)
        {
            context.taxies.Add(new Taxi(d.Id,d.IsAvailable));
        }
 

        // PUT api/<TaxiController>/5
        [HttpPut("{id}")]
        public ActionResult<Taxi> Put( [FromBody] Taxi t)
        {
            var v = context.taxies.Find(x => x.Id == t.Id);
            if (v == null)
                return NotFound();
            v.IsAvailable = false;
            return NoContent();
        }

        // DELETE api/<TaxiController>/5
        [HttpDelete("{id}")]
        public ActionResult<Taxi> Delete(int id)
        {
            var v = context.taxies.Find(x => x.Id == id);
            if (v == null)
                return NotFound();
            context.taxies.Remove(v);
            return NoContent();
        }
    }
}
