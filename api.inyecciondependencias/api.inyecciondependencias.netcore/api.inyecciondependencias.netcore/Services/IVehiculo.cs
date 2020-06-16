using api.inyecciondependencias.netcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.inyecciondependencias.netcore.Services
{
    public interface IVehiculoService
    {
        Vehiculo GetVehiculo(int id);
        string Arrancar();
    }
}
