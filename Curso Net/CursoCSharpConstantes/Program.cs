using System;

namespace CursoCSharpConstantes
{
    class Program
    {
        //Así se define una constante
        public const string NOMBRE = "Pablo";
        public const int NUMERO_PEDIDOS_MAXIMOS = 10;


        static void Main(string[] args)
        {
            //Esto no se puede hacer:
            //NUMERO_PEDIDOS_MAXIMOS = 12;

            for (int i = 0; i < 12; i++)
            {
                if (i < NUMERO_PEDIDOS_MAXIMOS)
                {
                    Console.Write(i);
                }
            }
            
        }
    }
}
