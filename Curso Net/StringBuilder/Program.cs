using System;
using System.Text;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder nos permite contruir cadenas de forma eficiente y a su vez podemos utilizarla en lugar de las concatenaciones
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder("Hola soy Superman");

            sb.Append("Hola soy Batman ");
            sb.Append("y vivo en Gotham");

            Console.WriteLine(sb);

            sb2.AppendLine(" y vivo en la Metrópolis ");
            sb2.AppendFormat("actualmente es {0:dd/MM/yyyy}", DateTime.Now);
            Console.WriteLine(sb2);
            Console.ReadLine();
        }
    }
}
