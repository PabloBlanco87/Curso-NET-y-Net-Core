using System;
using System.Collections.Generic;
using System.Text;

namespace Mod18_D
{
    class DDBBService
    {
        public void GetDatos()
        {
            //implementacion de obtencion de datos
        }
    }

    class AccesoADatos
    {
        private DDBBService databaseService;

        public AccesoADatos(DDBBService databaseService)
        {
            this.databaseService = databaseService;
        }

        void GetDatos()
        {
            //obtiene los datos
            databaseService.GetDatos();
        }
    }
}
