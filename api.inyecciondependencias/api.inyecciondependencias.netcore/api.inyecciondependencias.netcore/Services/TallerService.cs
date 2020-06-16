using api.inyecciondependencias.netcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.inyecciondependencias.netcore.Services
{
    public class TallerService : ITallerService
    {

        private readonly IVehiculoService _vehiculoService;

        public TallerService(IVehiculoService vehiculoService)
        {
            _vehiculoService = vehiculoService;
        }

        public string Reparar()
        {

            return _vehiculoService.Arrancar();

        }
    }
}
