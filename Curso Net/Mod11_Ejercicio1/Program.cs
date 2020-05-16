using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;



namespace Mod11_Ejercicio1
{
    /*Crea un programa que use un diccionario, clave entera y valor string. Se pedirá por consola, un numero y una cadena, 
     * que se ira insertando en el diccionario, hasta que se introduzca la clave "0", una vez se pulse "0", se pedirá por 
     * pantalla que se introduzca una cadena de 2 letras.  se mostrara consultando el diccionario, todas las claves 
     * que contienen esos 2 caracteres en los valores del diccionario.*/

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            int clave = 1;
            string valor;
            bool flag = false;

            do
            {
                Write("Por favor, introduzca un número: ");
                clave = ToInt32(ReadLine());

                if (clave == 0)
                    break;

                Write("Por favor, introduzca una cadena: ");
                valor = ReadLine();
                diccionario.Add(clave, valor);

            } while (true);

            Write("Por favor, introduzca una cadena de dos letras: ");
            valor = ReadLine();

            if (valor.Length < 2)
            {
                do
                {
                    Write("Es obligatorio que la cadena sea de dos letras, vuelva a intentarlo: ");
                    valor = ReadLine();
                } while (valor.Length < 2);
            }

            foreach (var item in diccionario)
            {
                if (item.Value.Contains(valor))
                {
                    WriteLine(item.Value);
                    flag = true;
                }
            }

            if (!flag)
            {
                WriteLine("No existen coincidencias");
            }

            ReadLine();
        }
    }
}
