
using AutoMapper;
using DotenetProject.Models;
using DotenetProject.Solid.Core.Enitities;
using DotenetProject.Solid.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solid.core.DTOs;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace DotenetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxiController : ControllerBase
    {

        private readonly ITaxiService _taxiService;
        private readonly IMapper _mapper;

        public TaxiController(ITaxiService taxiService,IMapper mapper)
        {
            _taxiService = taxiService;
            _mapper = mapper;   
        }


        // GET: api/<TaxiController>
        [HttpGet]
        public ActionResult Get()
        {
            var list= _taxiService.GetTaxis();
            var listDto = (_mapper.Map<IEnumerable< TaxiDto>>(list));
            
            return Ok(listDto);
        }

        // GET api/<TaxiController>/5
        [HttpGet("{id}")]
        public ActionResult<Taxi> Get(int id)
        {
            var item= _taxiService.GetTaxi(id);
            return Ok(_mapper.Map<TaxiDto>(item));
        }

        // POST api/<TaxiController>
        [HttpPost]
        public async Task<Taxi> Post([FromBody] TaxiPostModel t)
        {
            var tcast=new Taxi { Id=t.Id, IsAvailable=t.IsAvailable};
                 return await _taxiService.AddTaxiAsync(tcast);
        }


        // PUT api/<TaxiController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Taxi>> Put(int id, [FromBody] TaxiPostModel t)
        {
            var tcast = new Taxi { Id = t.Id, IsAvailable = t.IsAvailable };
            return await Task.Run(()=> Ok(_taxiService.UpdateTaxiAsync(id, tcast)));
        }

        // DELETE api/<TaxiController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Taxi>> Delete(int id)
        {
           await _taxiService.DeleteTaxiAsync(id);
            return Ok();
        }
    }
}
