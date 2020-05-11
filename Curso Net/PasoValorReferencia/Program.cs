using System;
using static System.Console;

namespace PasoValorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 25;
            int numero2 = 55;

            WriteLine(numero1);

            CambiarPorValor(numero1);
            WriteLine(numero1);

            CambiarPorReferencia(ref numero1);
            WriteLine(numero1);

            Devuelve2ValoresPorReferencia(ref numero1, ref numero2);
            WriteLine(numero1 + " " + numero2);
            Read();


        }

        //Paso por valor (solo cambia el valor en el ámbito de esta función)
        public static void CambiarPorValor(int numero)
        {
            numero = 10;
        }

        //Paso por referencia (cambia el valor original)
        public static void CambiarPorReferencia(ref int numero)
        {
            numero = 32;
        }

        //Función que devuelve dos valores por referencia (cambia el valor original)
        public static void Devuelve2ValoresPorReferencia(ref int numero1, ref int numero2)
        {
            numero1 = 10;
            numero2 = 20;
        }
    }
}
