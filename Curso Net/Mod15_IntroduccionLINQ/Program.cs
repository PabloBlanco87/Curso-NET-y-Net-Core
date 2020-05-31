using System;
using System.Collections.Generic;
using System.Linq;

namespace Mod15_IntroduccionLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source
            int[] scores = new int[] { 97, 92, 81, 60 };

            //Define the query expression
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            //Execute the query
            foreach (var item in scoreQuery)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
    }
}
