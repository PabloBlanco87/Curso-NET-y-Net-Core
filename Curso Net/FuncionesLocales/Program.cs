using System;
using System.Collections.Generic;
using static System.Console;

namespace FuncionesLocales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una función local no es más que una función dentro de otra función para realizar 
             * acciones y que solo se ven y se pueden llamar dentro del ámbito de la función principal*/

            //FuncionPrincipal(12);

            EjemploFuncionLocal();
           
            Read();
        }

        public static void FuncionPrincipal(int numero)
        {
            WriteLine("Estamos dentro de la función principal con número " + numero);
            numero = numero + 10;

            FuncionLocal(numero);

            void FuncionLocal(int numeroLocal)
            {
                numeroLocal = numeroLocal * 15;
                WriteLine(numeroLocal);
            }
        }

        public static void EjemploFuncionLocal()
        {
            int total = 0;
            List<int> lista = new List<int>();
            lista.Add(4);
            lista.Add(5);
            lista.Add(17);

            foreach (var item in lista)
            {
                total = Suma(item, total);
                WriteLine(total);
            }
            int Suma(int numero, int totalSuma)
            {
                return numero + totalSuma;
            }
        }
    }
}
