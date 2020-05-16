using System;

namespace Mod11_Depuracion
{

    //F10 va pasando linea por línea
    //F5 hasta el siguiente putno de interrupcion
    //F11 salta al método donde la línea donde estamos está llamando
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 20;

            int suma = Suma(num1, num2);
            int multiplicacion = Multiplicacion(num1, num2);

        }

        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}

