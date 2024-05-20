
using AutoMapper;
using DotenetProject.Models;
using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solid.core.DTOs;

namespace DotenetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _DriverService;
        private readonly IMapper _mapper;
        public DriverController(IDriverService driverService, IMapper mapper)
        {
            _DriverService = driverService;
            _mapper = mapper;
        }

      //  GET: api/<DriverController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<DriverDto>>( _DriverService.GetDrivers()));
        }

      //  GET api/<DriverController>/5
        [HttpGet("{id}")]
        public ActionResult<Driver> GetOne(int id)
        {
            return _DriverService.GetDriver(id);
        }

      //  POST api/<DriverController>
        [HttpPost]
        public async Task PostAsync([FromBody] DriverPostModel d)
        {
            var dcast=new Driver { Id = d.Id, Name=d.Name, TaxiId=d.TaxiId };
          await  _DriverService.AddDriverAsync(dcast);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Driver>> PutDriverAsync(int id, [FromBody] DriverPostModel d)
        {
            var dcast = new Driver { Id = d.Id, Name = d.Name, TaxiId = d.TaxiId};
            return await Task.Run(()=> Ok(_DriverService.UpdateDriverAsync(id, dcast)));
        }

        //DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Driver>> Delete(int id)
        {
          await  _DriverService.DeleteDriverAsync(id);
            return  Ok();
        }
    }
}
