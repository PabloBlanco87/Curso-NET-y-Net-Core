using System;
using System.Collections;
using static System.Console;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*No se recomienda que utilice el ArrayList clase para el nuevo desarrollo. En su lugar, se recomienda que use 
             * el tipo genérico List<T> clase.La ArrayList clase está diseñada para contener colecciones heterogéneas de objetos.
             * Sin embargo, no siempre ofrece el mejor rendimiento. En su lugar, se recomienda lo siguiente:
             * 
             * Para obtener una colección heterogénea de objetos, utilice el List<Object>(en C#)
             * 
             * Para obtener una colección homogénea de objetos, utilice el List < T > clase.
             * 
             * Consulte consideraciones de rendimiento en el List < T >*/


            //ArrayList guarda los elementos como una lista, es como un array que puede cambiar su tamaño según lo necesitemos
            ArrayList lista = new ArrayList();

            //Añadir elementos
            lista.Add(85);
            lista.Add("Pablo");

            //Recorrer ArrayList
            foreach (var item in lista)
            {
                Console.WriteLine(lista);
            }

            //Acceder a un elemento concreto
            var elemento = lista[0];
            var elemento1 = lista[1];

            //nº de elementos de la lista
            int contador = lista.Count;

            //Insertar elemento en una posición determinada
            lista.Insert(1, "Superman");

            foreach (var item in lista)
            {
                Console.WriteLine(lista);
            }

            //Eliminar elemento en una posición determinada
            lista.RemoveAt(1);

            foreach (var item in lista)
            {
                Console.WriteLine(lista);
            }

            ReadLine();
        }
    }
}
