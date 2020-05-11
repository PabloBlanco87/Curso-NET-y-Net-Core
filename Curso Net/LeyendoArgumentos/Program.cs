using System;

namespace LeyendoArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En el explorador de soluciones, botón derecho a LeyendoArgumentos, seleccionar propiedades
             *seleccionar la pestaña Debug/Depurar y en argumentos de aplicación ponerlos */

            Console.WriteLine("hay " + args.Length + " elementos");

            foreach(var argumentos in args)
            {
                Console.WriteLine(argumentos);
            }
        }
    }
}
