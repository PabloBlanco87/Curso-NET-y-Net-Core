using System;
using System.Collections.Generic;
using System.Text;

namespace Mod18_D
{
    interface Conexion
    {
        void GetDatos();
        void SetDatos();
    }

    class AccesoADatos
    {
        private Conexion conexion;

        public AccesoADatos(Conexion conexion)
        {
            this.conexion = conexion;
        }

        void GetDatos()
        {
            conexion.GetDatos();
        }
    }
}
