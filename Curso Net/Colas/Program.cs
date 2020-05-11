using System;
using System.Collections;

namespace Colas
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIFO -->  First In, First Out --> sale el primero que entra
            Queue cola = new Queue();

            //Para añadir elementos a la cola
            cola.Enqueue(3);
            cola.Enqueue(5);
            cola.Enqueue(1);

            //Extraer valores de la cola
            var valorCola = cola.Dequeue();
            Console.WriteLine(valorCola);

            valorCola = cola.Dequeue();
            Console.WriteLine(valorCola);

            //Para observar el valor
            var valor = cola.Peek();
            Console.WriteLine(valor);

            //Comprobar si existe un valor
            if (cola.Contains(5))
            {
                //codigo
            }

            //Borrar valores en cola
            cola.Clear();

            //Conocer cuantos elementos hay en la cola
            int elementos = cola.Count;
            Console.WriteLine(elementos);

            cola.Enqueue(25);
            cola.Enqueue(16);

            //Recorrer cola
            foreach (var item in cola)
            {
                Console.WriteLine(item);

            }

            Console.Read();
        }
    }
}
