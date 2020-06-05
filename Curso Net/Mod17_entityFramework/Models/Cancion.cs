using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod17_entityFramework.Models
{
    public class Cancion
    {
        public int CancionId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan Duracion { get; set; }
    }
}
