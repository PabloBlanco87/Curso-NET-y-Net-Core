using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mod17_Ejercicio.Services;

namespace Mod17_Ejercicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IAlumnoService _alumnoService;
        private readonly IProfesorService _profesorService;
        private readonly IColegioService _colegioService;
        private readonly IClaseService _claseService;

        public ValuesController(IAlumnoService alumnoService, IProfesorService profesorService, 
            IColegioService colegioService, IClaseService claseService)
        {
            _alumnoService = alumnoService;
            _profesorService = profesorService;
            _colegioService = colegioService;
            _claseService = claseService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _alumnoService.AddAlumno(new Models.Alumno
            {
                Nombre = "Pablo",
                Apellidos = "Blanco Hernandez",
                Edad = 32
            });

            _colegioService.AddColegio(new Models.Colegio
            {
                Nombre = "Mario Benedetti"
            });

            _claseService.AddClase(new Models.Clase
            {
                Nombre = "5ºA",
                ColegioId = 1
            });

            _alumnoService.AddAlumno(new Models.Alumno
            {
                ClaseId = 1,
                Nombre = "Pablo",
                Apellidos = "Blanco Hernandez",
                Edad = 32
            });

            _profesorService.AddProfesor(new Models.Profesor
            {
                ClaseId = 1,
                Nombre = "Claudia",
                Apellidos = "Moreno González",
                Edad = 35
            });

            var alumno= _alumnoService.GetAlumno(1);
            var nombreClase = alumno.Clase.Nombre;

            var profesor = _profesorService.GetProfesor(1);
            nombreClase = profesor.Clase.Nombre;

            var clase = _claseService.GetClase(1);
            var nombreColegio = clase.Colegio.Nombre;

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
