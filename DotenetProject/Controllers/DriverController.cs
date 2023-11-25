
using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotenetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _DriverService;

        public DriverController(IDriverService driverService)
        {
            _DriverService = driverService;
        }

      //  GET: api/<DriverController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_DriverService.GetDrivers());
        }

      //  GET api/<DriverController>/5
        [HttpGet("{id}")]
        public ActionResult<Driver> GetOne(int id)
        {
            return _DriverService.GetDriver(id);
        }

      //  POST api/<DriverController>
        [HttpPost]
        public void Post([FromBody] Driver d)
        {
            _DriverService.AddDriver(d);
        }

       // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public ActionResult<Driver> PutDriver(int id, [FromBody] Driver d)
        {
            return Ok(_DriverService.UpdateDriver(id, d));
        }

        //DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public ActionResult<Driver> Delete(int id)
        {
            _DriverService.DeleteDriver(id);
            return Ok();
        }
    }
}
