using System;

namespace Clases_Estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diferencia entre clases y estructuras
            //Las clases son tipos por referencia y las estructuras son tipos por valor

            //Clase Point
            Point punto = new Point();
            punto.X = 10;
            punto.Y = 8;

            //Estructura PointStruct
            PointStruct puntoStruct = new PointStruct();
            puntoStruct.X = 20;
            puntoStruct.Y = 7;

            SumaCoordenadas(punto);
            SumarCoordenadas(puntoStruct);

            Console.WriteLine($"Suma de coordenadas clase: X= {punto.X} Y= {punto.Y}");     //20 y 18 (por referencia)
            Console.WriteLine($"Suma de coordenadas struct: X= {puntoStruct.X} Y= {puntoStruct.Y}");     //20 y 7 (por valor)
            Console.ReadKey();

        }

        public static void SumaCoordenadas(Point point)
        {
            point.X = point.X + 10;
            point.Y = point.Y + 10;
        }

        public static void SumarCoordenadas(PointStruct point)
        {
            point.X = point.X + 10;
            point.Y = point.Y + 10;
        }
    }
}
