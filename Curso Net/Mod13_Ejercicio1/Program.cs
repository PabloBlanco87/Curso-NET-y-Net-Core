using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Console;

namespace Mod13_Ejercicio1
{
    /*Crear un programa que realice la siguiente funcionalidad:
     * 
     * Se pedirá por consola el nombre de una persona, su edad y su localidad, se guardara en un archivo con 
     * el siguiente formato, nombre|edad|localidad;  uno detrás del otro "|" separa datos ";" separa registros. 
     * Cuando se inserte, se pedirá si quiere introducir más personas, "S o N", se podrán introducir personas 
     * hasta que se pulse en "N". cuando se pulse en "N", se listaran todas las personas que están introducidas 
     * en el archivo. Una vez se salga del programa, si lo volvemos a ejecutar e introducimos mas personas, 
     * una vez pulsado de nuevo "N", tendrán que salir todas las personas, las introducidas en veces anteriores y las nuevas.
     * 
     * Requisitos: se tendrán que usar todos los componentes vistos hasta la fecha, clases (Clase persona), 
     * propiedades, Interfaces, métodos, funciones, bucles, condicionales control de excepciones y archivos.
     * 
     * Cuidado: tienes que realizar todas las comprobaciones necesarias de validaciones.*/

    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsAbrir = new FileStream("miArchivo.txt", FileMode.OpenOrCreate);
            fsAbrir.Close();

            FileStream fsEscribir = new FileStream("miArchivo.txt", FileMode.Append);

            string cadena, name, edad, localidad, eleccion;

            do
            {
                name = DimeNombre();
                edad = DimeEdad();
                localidad = DimeLocalidad();
                cadena = $"{name} | {edad} | {localidad} ; ";
                fsEscribir.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);

                Write("¿Desea registrar a otra persona? Pulse S o N: ");
                eleccion = ReadLine();
                eleccion.ToLower();
                while (eleccion != "n" && eleccion != "s")
                {
                    Write("Introduzca S o N: ");
                    eleccion = ReadLine();
                    eleccion.ToLower();
                }

            } while (eleccion != "n");

            fsEscribir.Close();

            FileStream fsLeer = new FileStream("miArchivo.txt", FileMode.Open);
            byte[] buffer = new byte[5000000];
            fsLeer.Read(buffer, 0, (int)fsLeer.Length);
            fsLeer.Close();

            //Construimos un string con todo lo almacenado en el array de bytes
            string todoLeido = ASCIIEncoding.ASCII.GetString(buffer);
            //Construimos una lista con cada uno de los elementos encontrados, separándolos por ';'
            List<string> listaPersonas = todoLeido.Split(';').ToList();
            //Eliminamos el último registro, que siempre nos va a dar uno de más, y nos saldrá una excepción
            listaPersonas.RemoveAt(listaPersonas.Count - 1);

            foreach (var item in listaPersonas)
            {
                Persona persona= ConstruyePersonas(item);
                WriteLine($"Nombre:{persona.Nombre},Edad: {persona.Edad},Localidad: {persona.Localidad}.");
            }

            ReadKey();
        }

        public static Persona ConstruyePersonas(string linea)
        {
            string[] datosPersona = linea.Split('|');

            return new Persona
            {
                Nombre = datosPersona[0],
                Edad = datosPersona[1],
                Localidad = datosPersona[2]
            };
        }


        public static string DimeNombre()
        {
            Write($"Por favor, introduzca el nombre de la persona: ");
            string nombre = ReadLine();
            return nombre;
        }

        public static string DimeEdad()
        {
            Write($"Ahora introduzca la edad de la persona: ");
            string edad = ReadLine();
            return edad;
        }

        public static string DimeLocalidad()
        {
            Write($"Por último, introduzca la localidad de la persona: ");
            string localidad = ReadLine();
            return localidad;
        }

    }
}