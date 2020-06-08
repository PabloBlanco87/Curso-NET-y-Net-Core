using System;
using System.Collections.Generic;
using System.Text;

namespace Mod18_I.Correcto
{
    interface IVehiculo2
    {
        void UsaCombustible();
    }

    interface IVehiculoTerrestre
    {
        void Corre();
        void TieneRuedas();
    }

    interface IVehiculoAereo
    {
        void Vuela();
    }

    interface IVehiculoNautico
    {
        void Navega();
    }
}
