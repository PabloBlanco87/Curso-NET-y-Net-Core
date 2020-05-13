using System;

namespace Ejercicio5
{
    class Program
    {
        /*Crea una clase estática "Producto", con un método estático , 
         * que sume 2 valores pasados por parámetro, úsalo desde otro lugar.*/

        static void Main(string[] args)
        {
            Producto.Suma(5, 16);
            Console.ReadKey();
        }
    }

    public static class Producto
    {
        public static void Suma(int num1, int num2) => Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    }
}
