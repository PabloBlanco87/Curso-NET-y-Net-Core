using System;

namespace MetodosDeExtension
{

    //Permiten agregar métodos a los tipos existentes sin crear un nuevo tipo derivado.
    class Program
    {
        static void Main(string[] args)
        {
            //string ejemplo = "Hola";
            //ejemplo.

            string s = "Hello Extension Methods";
            int i = s.WordCount();
        }
    }
}
