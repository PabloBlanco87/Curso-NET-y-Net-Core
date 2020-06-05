using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Models
{
    public class Clase
    {
        public int ClaseId { get; set; }
        public string Nombre { get; set; }

        public Colegio Colegio { get; set; }
        public int ColegioId { get; set; }

        public List<Alumno> Alumno { get; set; }


        
    }
}
