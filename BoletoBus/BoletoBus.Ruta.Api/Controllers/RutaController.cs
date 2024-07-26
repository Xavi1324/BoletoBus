using BoletoBus.Ruta.Application.Dtos;
using BoletoBus.Ruta.Application.Interfaces;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletoBus.Ruta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RutaController : ControllerBase
    {
        private readonly IRutaService rutaService;
        public RutaController(IRutaService rutaService)
        {
            this.rutaService = rutaService;
        }
        // GET: api/<RutaController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.rutaService.GetRutas();
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // GET api/<RutaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = this.rutaService.GetRutas(id);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // POST api/<RutaController>
        [HttpPost]
        public IActionResult Post([FromBody] RutaSaveModel rutaSaveModel)
        {
            var result = this.rutaService.SaveRuta(rutaSaveModel);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // PUT api/<RutaController>/5
        [HttpPut("UpDateRuta")]
        public IActionResult Put(RutaUpdateModel rutaUpdateModel)
        {
            var result = this.rutaService.UpDateRutas(rutaUpdateModel);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // DELETE api/<RutaController>/5
        [HttpDelete("DeleteRuta")]
        public IActionResult Delete(RutaDeleteModel rutaDeleteModel)
        {
            var result = this.rutaService.DeleteRuta(rutaDeleteModel);
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
