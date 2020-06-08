using System;
using System.Collections.Generic;
using System.Text;

namespace Mod18_I.Correcto
{
    class Coche2 : IVehiculoTerrestre, IVehiculo2
    {
        public void Corre()
        {
            throw new NotImplementedException();
        }

        public void TieneRuedas()
        {
            throw new NotImplementedException();
        }

        public void UsaCombustible()
        {
            throw new NotImplementedException();
        }
    }

    class Moto2 : IVehiculoTerrestre, IVehiculo2
    {
        public void Corre()
        {
            throw new NotImplementedException();
        }

        public void TieneRuedas()
        {
            throw new NotImplementedException();
        }

        public void UsaCombustible()
        {
            throw new NotImplementedException();
        }
    }

    class Avion2 : IVehiculo2, IVehiculoAereo
    {
        public void UsaCombustible()
        {
            throw new NotImplementedException();
        }

        public void Vuela()
        {
            throw new NotImplementedException();
        }
    }
    class Barco : IVehiculo2, IVehiculoNautico
    {
        public void Navega()
        {
            throw new NotImplementedException();
        }

        public void UsaCombustible()
        {
            throw new NotImplementedException();
        }
    }
}
