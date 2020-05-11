using System;
using static System.Console;

namespace EjemploFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcion = PintaMenu();

            while (opcion != "5")
            {
                EjecutarOpcion(opcion);
                opcion = PintaMenu();
            }

        }

        public static string PintaMenu()
        {
            WriteLine("*** MENU ***");
            WriteLine("*** 1. SUMA ***");
            WriteLine("*** 2. RESTA ***");
            WriteLine("*** 3. MULTIPLICACIÓN ***");
            WriteLine("*** 4. MI OPERACIÓN ***");
            WriteLine("*** 5. SALIR ***");
            return ReadLine();
        }

        public static void EjecutarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    WriteLine(Suma(1, 7));
                    break;
                case "2":
                    WriteLine(Resta(15, 9));
                    break;
                case "3":
                    WriteLine(Multiplicacion(10, 3));
                    break;
                case "4":
                    WriteLine(MiOperacion(5, 2));
                    break;
                default:
                    break;
            }
        }

        public static int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Resta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public static int Multiplicacion(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        //Aquí estamos reutilizando código
        public static int MiOperacion(int numero1, int numero2)
        {
            var numeroSuma = Suma(numero1, numero2);
            var resta = Resta(numeroSuma, numero2);
            var multiplicacion = Multiplicacion(numeroSuma, resta);

            return multiplicacion;
        }
    }
}
