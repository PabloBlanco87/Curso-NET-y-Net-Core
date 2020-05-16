using System;

namespace Mod11_Tuplas
{
    /*Una tupla es una estructura de datos que nos permite almacenar hasta 8 valores diferentes 
    de diferentes tipos, que están relacionados de algún modo y usando una sola variable.*/
    class Program
    {
        static void Main(string[] args)
        {
            var tupla = new Tuple<int, string, string, DateTime>(1, "Rodrigo", "Alejandro", DateTime.Now);

            var tupla2 = Tuple.Create(1, "Rodrigo", "Alejandro", DateTime.Now);

            var ejemplo = Ejemplo();

            var entero = ejemplo.Item1;
            var nombre1 = ejemplo.Item2;

        }

        public static Tuple<int, string, string, DateTime> Ejemplo()
        {
            return new Tuple<int, string, string, DateTime>(1, "Rodrigo", "Alejandro", DateTime.Now);
        }
    }
}
