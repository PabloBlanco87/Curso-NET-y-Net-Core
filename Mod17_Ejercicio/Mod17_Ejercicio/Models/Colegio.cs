using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_Ejercicio.Models
{
    public class Colegio
    {
        public int ColegioId { get; set; }
        public string Nombre { get; set; }

        List<Clase> Clases { get; set; }

    }
}
