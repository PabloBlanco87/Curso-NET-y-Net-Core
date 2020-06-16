using api.inyecciondependencias.netcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.inyecciondependencias.netcore.Services
{
    public class VehiculoService : IVehiculoService
    {

        public Vehiculo GetVehiculo(int id)
        {
            //consulta en bbdd obteniendo el vehiculo
            return new Vehiculo
            {

            };
        }

        public string Arrancar()
        {
            return "Arrancando";
        }
    }
}
