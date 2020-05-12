using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato();
            Perro perro = new Perro();

            List<Animal> zoo = new List<Animal>();

            zoo.Add(gato);
            zoo.Add(perro);

            foreach (var item in zoo)
            {
                item.HacerRuido();
            }

            //El foreach equivale a hacer lo siguiente
            gato.HacerRuido();
            perro.HacerRuido();
            Console.Read();
        }
    }
}
