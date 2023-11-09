using DotenetProject.Enitities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotenetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        DataContext context;
        public DriverController(DataContext data)
        {
            context = data;
        }
      
        // GET: api/<DriverController>
        [HttpGet]
        public  IEnumerable<Driver> GetAll()
        {
            return context.drivers;
        }

        // GET api/<DriverController>/5
        [HttpGet("{id}")]
        public ActionResult<Driver> GetOne(int id)
        {
            var v = context.drivers.Find(x => x.Id == id);
            if (v == null)
                return NotFound();
            return v;
        }

        // POST api/<DriverController>
        [HttpPost]
        public void Post([FromBody] Driver d)
        {
            context.drivers.Add(new Driver(d.Id, d.Name));
        }

        // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public ActionResult<Driver> PostDriver( [FromBody]Driver d )
        {
            var v = context.drivers.Find(x => x.Id == d.Id);
            if (v == null)
                return NotFound();
            v.Name = d.Name;
            return NoContent();
        }

        // DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public ActionResult<Driver> Delete(int id)
        {
            var driver = context.drivers.Find(x => x.Id == id);
            if (driver == null)
                return NotFound();
            context.drivers.Remove(driver);
            return NoContent();
        }
    }
}
