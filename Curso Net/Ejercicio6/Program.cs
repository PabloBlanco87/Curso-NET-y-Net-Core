using System;

namespace Ejercicio6
{
    class Program
    {

        /*Crea una clase "Animal" con las siguientes propiedades: Tipo, color pelo, 
         * es domestico, numero de patas, con el tipo de dato que creas conveniente.crea una instancia de esa clase, 
         * y asigna los valores a las propiedades.*/

        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Tipo = "León";
            animal.ColorPelo = "Marron";
            animal.Domestico = false;
            animal.NumeroPatas = 4;

            string domestico = EsDomestico(animal.Domestico);

            Console.WriteLine($"El animal es de tipo {animal.Tipo}, de color {animal.ColorPelo}, " +
                $"{domestico}, y tiene {animal.NumeroPatas} patas. ");

            //Se podría hacer más sencillo con un constructor
            Animal animal2 = new Animal("Elefante", "Gris", true, 4);

            domestico = EsDomestico(animal2.Domestico);

            Console.WriteLine($"El animal es de tipo {animal2.Tipo}, de color {animal2.ColorPelo}, " +
                $"{domestico}, y tiene {animal2.NumeroPatas} patas. ");


            Console.ReadKey();
        }

        public static string EsDomestico(bool domestico)
        {
            string output;
            if (domestico)
                output = "es domestico";
            else
                output = "no es domestico";
            return output;
        }
    }
}
