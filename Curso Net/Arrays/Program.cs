using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para crear un array
            //type[] nombreArray;

            int[] arrayEnteros;
            int[] arrayEnteros2 = new int[5];
            int[] arrayEnteros3 = { 1, 2, 5, 10 };
            int[,] arrayEnteros2D = new int[2, 2];
            int[,] arrayEnteros2D2 = { { 2, 3 }, { 5, 8 } };
            int[][] arrayEnterosEscalonados = new int[6][];

            arrayEnterosEscalonados[0] = new int[4] { 3, 6, 7, 2 };
            arrayEnterosEscalonados[1] = new int[2] { 8, 12 };

            for (int i = 0; i < arrayEnteros3.Length; i++)
            {
                Console.WriteLine(arrayEnteros3[1]);
            }

            foreach (var item in arrayEnteros3)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < arrayEnteros2D2.GetLongLength(0); i++)
            {
                for (int j= 0; j < arrayEnteros2D2.GetLongLength(1); i++)
                {
                    Console.WriteLine(arrayEnteros2D2[i,j]);
                }
            }

            for (int i = 0; i < arrayEnterosEscalonados.GetLongLength(0); i++)
            {
                for (int j = 0; j < arrayEnterosEscalonados.GetLongLength(1); i++)
                {
                    Console.WriteLine(arrayEnterosEscalonados[i][j]);
                }
            }
        }
    }
}
