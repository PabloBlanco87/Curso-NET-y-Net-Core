using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            var numero = 15;

            switch (numero)
            {
                case 1: Console.Write("Es un uno");
                    break;
                case 5: Console.Write("Es un cinco");
                    break;
                case 7: Console.Write("Es un siete");
                    break;
                case 10: Console.Write("Es un diez");
                    break;
                case 15: Console.Write("Es un quince");
                    break;
                default: Console.Write("No coincide con nada");
                    break;
            }
        }
    }
}
