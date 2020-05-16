using System;
using static System.Console;
using static System.Math;       //Incluimos la clase estática
using AliasHaciaMyClass = Mod11_InstruccionUsing.Ejemplo.Namespace.MyClass;


namespace Mod11_InstruccionUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Sqrt(3 * 3 + 4 * 4));

            AliasHaciaMyClass instance1 = new AliasHaciaMyClass();
            Console.WriteLine(instance1);

        }
    }
}
