using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class Coche : Vehiculo
    {
        public override void Desplazamiento() => Console.WriteLine("Los coches se mueven por tierra");
    }
}
