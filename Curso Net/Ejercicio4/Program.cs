using System;
using System.Collections.Generic;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear una Clase Vehículo, con las propiedades , Ruedas, puertas privadas, crear 3 constructores 
             * para asignar los valores de las propiedades, el constructor por defecto 
             * y 2 constructores mas que creas convenientes.*/

            Vehiculo vehiculo1 = new Vehiculo();
            Vehiculo vehiculo2 = new Vehiculo(8,2);
            Vehiculo vehiculo3 = new Vehiculo(10);

            List<Vehiculo> lista = new List<Vehiculo>();
            lista.Add(vehiculo1);
            lista.Add(vehiculo2);
            lista.Add(vehiculo3);

            foreach (var item in lista)
            {
                Console.WriteLine($"Ruedas: {item.Ruedas}, Puertas: {item.PuertasPrivadas}");
            }

            Console.ReadLine();
        }
    }
}
