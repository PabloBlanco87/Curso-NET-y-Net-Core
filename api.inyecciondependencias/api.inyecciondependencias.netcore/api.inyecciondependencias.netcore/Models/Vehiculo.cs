using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.inyecciondependencias.netcore.Models
{
    public class Vehiculo
    {

        public string ArrancarTerrestre()
        {
            return new Terrestre().Arrancar();
        }

        public string ArrancarAereo()
        {
            return new Aereo().Arrancar();
        }

        public string ArrancarNautico()
        {
            return new Nautico().Arrancar();
        }

    }
}
