using System;

namespace CursoCSharpIFELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            //If Else
            bool bandera = true;

            if (bandera)
            {
                //Si bandera = true
            }
            else
            {
                //Si bandera = false
            }

            int suma = 12 + 8;
            if(suma <= 30)
            {
                //Suma es menor o igual a 30
            }
            else
            {
                //Suma es mayor que 30
            }

            if(suma.GetType() == typeof(int))
            {
                //si suma es de tipo entero entonces entra
            }

            if (suma == 20 && bandera)
            {
                //si suma es = a 20 y bandera = true
            }
        }
    }
}
