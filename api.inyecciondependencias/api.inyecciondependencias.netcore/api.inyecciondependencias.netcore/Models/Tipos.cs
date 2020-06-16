using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.inyecciondependencias.netcore.Models
{
    public class Terrestre
    {
        public string Arrancar()
        {
            return "va por el suelo";
        }
    }

    public class Aereo
    {
        public string Arrancar()
        {
            return "va por el aire";
        }
    }

    public class Nautico
    {
        public string Arrancar()
        {
            return "va por el agua";
        }
    }
}
