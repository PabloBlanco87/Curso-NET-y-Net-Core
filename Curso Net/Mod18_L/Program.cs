using System;

namespace Mod18_L
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi coche = new Audi2018();
            coche.speed();  //corre 215

            Audi coche2 = new Audi2019();
            coche2.speed();  //corre 250
            Console.ReadLine();
        }
    }
}
