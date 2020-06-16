using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.inyecciondependencias.netcore.Services;
using api.inyecciondependencias.netcore.SolucionID;
using Microsoft.AspNetCore.Mvc;

namespace api.inyecciondependencias.netcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IVehiculoService _vehiculoService;
        private readonly ITallerService _tallerService;

        public ValuesController(IVehiculoService vehiculoService, ITallerService tallerService)
        {
            _vehiculoService = vehiculoService;
            _tallerService = tallerService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var terrestre = new Vehiculo(new Terrestre());
            var response =  terrestre.Arrancar();

            var nautico = new Vehiculo(new Nautico());
            var response2 = nautico.Arrancar();

            return string.Empty;

        }

        // GET api/values
        [HttpGet]
        [Route("ejemplo")]
        public ActionResult<string> Get2()
        {
            var response = _tallerService.Reparar();
            var response2 = _vehiculoService.Arrancar();

            return string.Empty;

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
