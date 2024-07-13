using BoletoBus.Reserva.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletoBus.Reserva.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaService reservaService;
        public ReservaController(IReservaService reservaService)
        {
            this.reservaService = reservaService;
        }
        // GET: api/<ReservaController>
        [HttpGet]
        public IActionResult Get()
        {
            var resul = this.reservaService.GetReservas();
            if (!resul.Success)
            {
                return BadRequest(resul);
            }
            else
            {
                return Ok(resul);
            }
        }

        // GET api/<ReservaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReservaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReservaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
