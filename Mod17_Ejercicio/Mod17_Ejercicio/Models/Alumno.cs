using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Models
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }


        public Clase Clase { get; set; }
        public int ClaseId { get; set; }


    }
}
