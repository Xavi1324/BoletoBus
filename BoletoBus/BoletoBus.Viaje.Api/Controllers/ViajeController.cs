using BoletoBus.Viaje.Application.Dtos;
using BoletoBus.Viaje.Application.Interfaces;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletoBus.Viaje.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViajeController : ControllerBase
    {
        private readonly IViajeService viajeService;
        public ViajeController(IViajeService viajeService)
        {
            this.viajeService = viajeService;
        }
        // GET: api/<ViajeController>
        [HttpGet("GetViaje")]
        public IActionResult Get()
        {
            var result = this.viajeService.GetViaje();
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // GET api/<ViajeController>/5
        [HttpGet("GetViajeById")]
        public IActionResult Get(int id)
        {
            var result = this.viajeService.GetViaje(id);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // POST api/<ViajeController>
        [HttpPost("SaveViaje")]
        public IActionResult Post([FromBody] ViajeSaveModel viajeSaveModel)
        {
            var result = this.viajeService.SaveViaje(viajeSaveModel);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // PUT api/<ViajeController>/5
        [HttpPost("UpdateViaje")]
        public IActionResult Put(ViajeUpdateModel viajeUpdateModel)
        {
            var result = this.viajeService.UpDateViaje(viajeUpdateModel);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // DELETE api/<ViajeController>/5
        [HttpPost("DeleteViaje")]
        public IActionResult Delete(ViajeDeleteModel viajeDeleteModel)
        {
            var result = this.viajeService.DeleteViaje(viajeDeleteModel);
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
