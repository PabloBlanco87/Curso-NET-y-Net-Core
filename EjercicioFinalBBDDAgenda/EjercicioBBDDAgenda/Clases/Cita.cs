using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBBDDAgenda.Clases
{
    public class Cita
    {
        public int CitaId { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }

        public Contacto Contacto { get; set; }
        public int ContactoId { get; set; }
    }
}
