using System;
using System.Collections;

namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Nos permite guardar elementos y cambiar su tamaño de forma dinámica. Trabaja de manera diferente al ArrayList. 
             * La pila es de tipo LIFO (Last In, First Out-->último en entrar es el primero en salir) (como una pila de platos)*/

            Stack pila = new Stack();

            //Para meter elementos a una pila con push
            pila.Push(1);
            pila.Push(5);
            pila.Push(10);
            pila.Push(3);

            //La información la obtendríamos en este orden: 3--> 10--> 5--> 1
            //Para sacar la información: Pop()

            var numero = pila.Pop();
            Console.WriteLine(numero);
            //cada vez que haces un pop, sacas el elemento cima de la pila

            //para recorrer una pila
            foreach (var item in pila)
            {
                Console.WriteLine(item);
            }

            //para saber cuantos elementos tiene la pila
            int contador = pila.Count;
            Console.WriteLine(contador);

            //Limpiar pila
            pila.Clear();

            if (pila.Contains(10))
            {
                Console.WriteLine("Contiene un 10");
            }

            Console.Read();

        }
    }
}
