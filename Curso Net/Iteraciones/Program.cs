using System;
using System.Collections.Generic;

namespace Iteraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////
            //do-while (una o varias vaces)//
            /////////////////////////////////
            var numero = 0;

            do
            {
                //Instrucciones
                Console.Write(numero);
                numero++;
            } while (numero < 10);

            ////////////////////////////////////
            //while (cero, una o varias veces)//
            ////////////////////////////////////
            numero = 5;

            while (numero == 5 || numero < 10)
            {
                Console.Write(numero);
                numero++;
            }

            /////////////////////////////////////
            //for (mientras expresión sea true)//
            /////////////////////////////////////

            for (int i = 0; i < 25; i++)
            {
                Console.Write(i);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.Write(i);
            }

            ///////////////////////////////////////////////////
            //foreach (ejecuta instruccion para cada elemento//
            ///////////////////////////////////////////////////
            var listaDeEnteros = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var item in ListaDeEnteros)
            {
                Console.WriteLine(item);
            }

            var listaDePersonas = new List<Persona>();

            var persona1 = new Persona()
            {
                Nombre = "Pablo",
                Apellido = "Blanco",
                Edad = 32
            };

            var persona2 = new Persona()
            {
                Nombre = "Claudia",
                Apellido = "Moreno",
                Edad = 35
            };

            listaDePersonas.Add(persona1);
            listaDePersonas.Add(persona2);

            foreach(var persona in listaDePersonas)
            {
                Console.WriteLine(persona.Nombre + " " + persona.Apellido + " tiene " + persona.Edad + " años.");
            }

        }

        public class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }
        }
    }
}
