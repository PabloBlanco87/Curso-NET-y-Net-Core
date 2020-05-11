using System;
using static System.Console;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores
            var suma = 5 + 12;
            var resta = 12 - 5;
            var multiplicacion = 5 * 12;
            var division = 10 / 5;
            var resto = 12 % 3;

            //Operadores de igualdad
            var numero1 = 5;
            var numero2 = 15;

            if (numero1 == numero2)
            {
                //Si es igual
            }

            if (numero1 != numero2)
            {
                //Si no es igual
            }

            if (numero1 < numero2)
            {
                //Si numero1 es menor que numero2
            }

            if (numero1 > numero2)
            {
                //Si numero1 es mayor que numero 2
            }

            if (numero1 <= numero2)
            {
                //Si numero1 es menor o igual que numero2
            }

            if (numero1 >= numero2)
            {
                //Si numero1 es mayor o igual que numero 2
            }

            //Operadores lógicos
            if (numero1 == 5 && numero2 == 3)
            {
                //Deben cumplirse ambas expresiones
            }

            if (numero1 == 5 || numero2 == 3)
            {
                //Deben cumplirse alguna de esas expresiones
            }
                     
        }
    }
}
