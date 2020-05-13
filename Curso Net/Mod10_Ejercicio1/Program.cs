using System;

namespace Mod10_Ejercicio1
{
    class Program
    {

        /*Crea una Clase "Animal" que implemente la interfaz "IAnimal" , la interfaz "IAnimal" tendrá los métodos, 
         *Andar, es perro, saltar. implementa estos métodos en la clase. y usa esa clase en un programa de consola.*/
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.EsPerro(true);
            animal.Andar(8);
            animal.Saltar(true);

            Console.ReadKey();
        }
    }
}
