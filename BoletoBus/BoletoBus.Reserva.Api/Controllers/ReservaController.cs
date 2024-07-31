
using BoletoBus.Reserva.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BoletoBus.Reserva.Application.Dtos;


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
        [HttpGet("GetReserva")]
        public IActionResult Get()
        {
            var result = this.reservaService.GetReservas();
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // GET api/<ReservaController>/5
        [HttpGet("GetReservabyId")]
        public IActionResult Get(int id)
        {
            var result = this.reservaService.GetReservas(id);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // POST api/<ReservaController>
        [HttpPost("SaveReserva")]
        public IActionResult Post([FromBody] ReservaSaveModel reservaSaveModel)
        {
            var result = this.reservaService.SaveReserva(reservaSaveModel);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // PUT api/<ReservaController>/5
        [HttpPost("UpdateReserva")]
        public IActionResult Put(ReservaUpdateModel reservaUpdateModel)
        {
            var result = this.reservaService.UpdateReservas(reservaUpdateModel);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // DELETE api/<ReservaController>/5
        [HttpPost("DeleteReserva")]
        public IActionResult Delete(ReservaDeleteModel reservaDeleteModel)
        {
            var result = this.reservaService.DeleteReservas(reservaDeleteModel);
            if(!result.Success)
            {
                return BadRequest(result);
            }
                
            {
                return Ok(result);
            }
        }
    }
}
