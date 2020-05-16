using System;

namespace Mod11_Ejercicio2
{
    /*Crear un programa que tenga una clase que acepte un tipo genérico. Esa clase tendrá un método que irá 
     * añadiendo a un Listado de ese tipo, todos los valores introducidos por consola.*/

    class Program
    {
        static void Main(string[] args)
        {
            ClaseGenerica<string> lista = new ClaseGenerica<string>();
            lista.Anade("Hola");
            lista.Anade("Adios");
            lista.Anade("Hello");
            lista.Anade("Bye");
            lista.Anade("Bonjour");
            lista.Anade("Hasta luego");

            lista.ObtenerValores();

            foreach (var item in lista.ObtenerValores())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
