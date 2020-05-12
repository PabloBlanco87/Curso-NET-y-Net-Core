using System;

namespace Encapsulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 5000;

            try
            {
                PointEncapsulado pointEncap = new PointEncapsulado();
                //pointEncap.SetX(80);
                //pointEncap.SetY(90);

                /*en la clase lo he puesto public con metodo {get;set;} 
                estos metodos se pueden hacer por ejemplo así {private get; set;} o {get; private set;}*/

                pointEncap.X=56;

                Console.WriteLine(pointEncap.GetX());
                Console.WriteLine(pointEncap.GetY());
            }
            catch(Exception ex)
            {
                Console.Write("Exception");
            }

            Console.Read();
            





        }
    }
}
