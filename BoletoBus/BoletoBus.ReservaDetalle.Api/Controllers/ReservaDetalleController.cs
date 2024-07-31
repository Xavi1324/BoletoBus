using BoletoBus.ReservaDetalle.Application.Dtos;
using BoletoBus.ReservaDetalle.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletoBus.ReservaDetalle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaDetalleController : ControllerBase
    {
        private readonly IReservaDetalleService reservaDetalleService;

        public ReservaDetalleController(IReservaDetalleService reservaDetalleService)
        {
            this.reservaDetalleService = reservaDetalleService;
        }
        // GET: api/<ReservaDetalleController>
        [HttpGet("GetReservaDetalle")]
        public IActionResult Get()
        {
            var result = this.reservaDetalleService.GetReservaDetalles();
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // GET api/<ReservaDetalleController>/5
        [HttpGet("GetReservaDetalleById")]
        public IActionResult Get(int id)
        {
            var result = this.reservaDetalleService.GetReservaDetalles(id);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // POST api/<ReservaDetalleController>
        [HttpPost("SaverReservaDetalle")]
        public IActionResult Post([FromBody] ReservaDetalleSave reservaDetalleSave)
        {
            var result = this.reservaDetalleService.SaveReservaDetalles(reservaDetalleSave);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // PUT api/<ReservaDetalleController>/5
        [HttpPost("UpdateReservaDetalle")]
        public IActionResult Put(ReservaDetalleUpdate reservaDetalleUpdate)
        {
            var result = this.reservaDetalleService.UpdateReservaDetalles(reservaDetalleUpdate);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // DELETE api/<ReservaDetalleController>/5
        [HttpPost("DeleteReservaDetalle")]
        public IActionResult Delete(ReservaDetalleDelete reservaDetalleDelete)
        {
            var result = this.reservaDetalleService.DeleteReservaDetalles(reservaDetalleDelete);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }
    }
}
