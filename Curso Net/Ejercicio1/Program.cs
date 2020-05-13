using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas. 
             * Después de realizar la carga por teclado de todos los datos imprimir los nombres de las personas 
             * mayores de edad (mayores o iguales a 18 años), se tendrá que crear una clase "Persona" 
             * que contenga las propiedades "Nombre" y "Edad". Utilizar todos los componentes vistos 
             * hasta la fecha (bucles, funciones, clases)*/

            List<Persona> listaPersonas = CreaListaPersonas();
            MayorDeEdad(listaPersonas);
            ReadKey();
        }

        public static List<Persona> CreaListaPersonas()
        {
            List<Persona> personas = new List<Persona>();
            string nombre;
            int edad;

            for (int i = 0; i < 5; i++)
            {
                Write($"Por favor, introduza el nombre de la persona {i+1}: ");
                nombre = ReadLine();

                Write($"Por favor, introduza la edad de {nombre}: ");
                edad = ToInt32(ReadLine());

                Persona persona = new Persona(nombre, edad);
                personas.Add(persona);
            }

            return personas;
        }

        public static void MayorDeEdad(List<Persona> personas)
        {
            foreach (var item in personas)
            {
                if (item.Edad >= 18)
                {
                    WriteLine($"{item.Nombre}, {item.Edad}");
                }
            }
        }
    }
}
