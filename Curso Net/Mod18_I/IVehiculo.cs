using System;
using System.Collections.Generic;
using System.Text;

namespace Mod18_I
{
    interface IVehiculo
    {
        void Corre();
        void UsaCombustible();
        void TieneRuedas();

        //Avion además de los metodos anteriores necesita un metodo vuela
        //void Vuela();
    }
}
