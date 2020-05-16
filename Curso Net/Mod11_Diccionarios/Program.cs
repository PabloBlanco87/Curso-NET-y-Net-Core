using System;
using System.Collections.Generic;

namespace Mod11_Diccionarios
{
    class Program
    {
        //Los diccionarios representan una colección de Key-value (clave valor)
        //Se utilizan para almacenar datos de clave valor, para hacer inserciones de bases de datos, o búsquedas, etc.

        static void Main(string[] args)
        {
            //para crear: Dictionary<key,value>
            Dictionary<string, string> openWith =
            new Dictionary<string, string>();

            //para añadir valores a un diccionario:
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            //Para obtener valores de diccionario:
            string valor = string.Empty;

            openWith.TryGetValue("dib", out valor);     //Esta es la más eficaz

            //otra forma de acceder a valores:
            var ejemplo1 = openWith["rtf"];

            //Si no contiene la clave doc, la añadimos con containsKey
            if (!openWith.ContainsKey("doc"))
            {
                openWith.Add("doc", "win.exe");
            }

            //Así le cambiamos el valor a la clave doc
            openWith["doc"] = "winword.exe";

            //recorrer el diccionario
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            //Obtener las keys, pero sin saber los valores
            Dictionary<string, string>.KeyCollection keyColl =
            openWith.Keys;

            //Eliminar registro
            openWith.Remove("doc");

            //Para ver que ha borrado la clave doc
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
        }
    }
}
