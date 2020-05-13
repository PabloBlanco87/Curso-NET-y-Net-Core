using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosDeExtension
{
    public static class MyExtensions
    {
        //Hace un Split por espacio, por punto o por símbolo, cuenta palabras

            //Debemos pasar como parametro el tipo que queremos añadir (con el this)
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
