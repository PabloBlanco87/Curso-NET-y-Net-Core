using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string saludo = Saludo("Pablo", "Blanco");
        }

        //Solo ejecutan código
        public static void Metodo()
        {
            Console.WriteLine("valor");
        }

        //Devuelve un valor pero no recibe valores
        public static int FuncionSinParametros()
        {
            return 12 + 3;
        }

        //Se le pasan parámetros y devuelve un valor
        public static string Saludo(string nombre, string apellidos)
        {
            return "Mi nombre es " + nombre + " " + apellidos;
        }

        //Método que no devuelve valor y recibe parámetros
        public static void MetodoConParametros(string nombre, string apellidos)
        {
            Console.WriteLine(nombre + " " + apellidos);
        }
    }
}
