using System;
using System.Collections.Generic;
using System.Text;

namespace Mod11_Ejercicio2
{
    public class ClaseGenerica<T>
    {
        List<T> listado = new List<T>();

        public void Anade(T valor)
        {
            listado.Add(valor);
        }

        public List<T> ObtenerValores()
        {
            return listado;
        }
    }
}
