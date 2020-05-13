using System;
using System.Collections.Generic;
using System.Text;

namespace Mod10_Ejercicio1
{
    public class Animal : IAnimal
    {
        public void Andar(int distancia)
        {
            Console.WriteLine($"El animal ha andado {distancia} kilómetros.");
        }

        public void EsPerro(bool afirma)
        {
            if (afirma)
            {
                Console.WriteLine($"El animal es un perro.");
            }
            else
            {
                Console.WriteLine($"El animal no es un perro.");
            }
        }

        public void Saltar(bool afirma)
        {
            if (afirma)
            {
                Console.WriteLine($"El animal sabe saltar.");
            }
            else
            {
                Console.WriteLine($"El animal no sabe saltar.");
            }
        }
    }
}
