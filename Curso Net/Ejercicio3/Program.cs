using System;
using System.Collections.Generic;

namespace Ejercicio3
{
    class Program
    {
        /*Crear una Clase Base "Vehículo", y 3 clases derivadas de Vehículo, Coche, Barco, Avión, 
         * crea unos métodos en vehículo, y sobrecargarlos en la clase derivada*/

        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            Coche coche1 = new Coche();
            vehiculos.Add(coche1);

            Barco barco1 = new Barco();
            vehiculos.Add(barco1);

            Avion avion1 = new Avion();
            vehiculos.Add(avion1);

            foreach (var item in vehiculos)
            {
                item.Desplazamiento();

            }

            Console.ReadKey();
        }
    }
}
