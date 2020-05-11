using System;
using System.Collections;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //MÉTODO DE BÚSQUEDA MUY RÁPIDO

            //Es una colección indexada, con clave valor
            Hashtable hashtable = new Hashtable();

            //Añadir valores
            hashtable.Add("Alejandro", 1.22);
            hashtable.Add("Rodrigo", 5.21);
            hashtable.Add("Miriam", 9.62);

            //Recorriendo Hashtable
            foreach (DictionaryEntry item in hashtable)     //Importante DictionaryEntry
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }

            //Obtener valor del Hashtable
            var valor = hashtable["Alejandro"];

            Console.WriteLine(valor);
            Console.ReadLine();

            //Cuántos elementos
            var contador = hashtable.Count;
            Console.WriteLine(contador);

            //Buscar
            if (hashtable.ContainsKey("Alejandro"))
            {
                //codigo
            }
            if (hashtable.ContainsValue(9.62))
            {
                //codigo
            }

            //Eliminar (siempre por la key)
            hashtable.Remove("Alejandro");

            //Recorriendo Hashtable
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }

            //Limpiar
            hashtable.Clear();

            //Recorriendo Hashtable
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }

            Console.Read();
        }
    }
}
