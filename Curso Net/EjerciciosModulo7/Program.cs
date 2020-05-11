using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace EjerciciosModulo7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio1
            /*Crear un programa, que recorra con un bucle for del 1 al 1000, insertando en cada iteración 
             * el valor del numero en un ArrayList. Una vez acabe el proceso , recorreremos ese ArrayList 
             * mostrando en consola la suma de los números  , ejemplo: 1, 3, 6, 10.*/
            /*
                        ArrayList arrayList = new ArrayList();

                        for (int i = 1; i <= 1000; i++)
                        {
                            arrayList.Add(i);
                        }

                        int contadorEj1 = 0;
                        foreach (int item in arrayList)
                        {
                            contadorEj1 = contadorEj1 + item;
                        }

                        WriteLine($"La suma es: {contadorEj1}");
                        Read();
            */
            #endregion

            #region Ejercicio2
            /*Pedir por pantalla 5 nombres, e insertarlo en una Lista (List) una vez insertados, 
             * se pedirá que introduzcamos un nombre, el programa tendrá que decirnos si ese 
             * nombre esta contenido en la lista.*/
            /*
           List<string> listaNombres = new List<string>();
           int contadorEj2 = 0;
           string nombreIntroducido;

           while (contadorEj2 < 5)
           {
               if (contadorEj2 == 0)
               {
                   Write("Por favor, introduzca un nombre: ");
                   nombreIntroducido = ReadLine();
               }
               else
               {
                   Write("Por favor, introduzca otro nombre: ");
                   nombreIntroducido = ReadLine();

               }
               listaNombres.Add(nombreIntroducido);
               contadorEj2++;
           }

           WriteLine("******************************");
           Write("Por favor, introduzca un nombre para ver si se encuentra en la lista: ");
           nombreIntroducido = ReadLine();

           if (listaNombres.Contains(nombreIntroducido))
           {
               Write($"El nombre {nombreIntroducido} se encuentra en la lista");
           }
           else
           {
               Write($"El nombre {nombreIntroducido} no se encuentra en la lista");
           }

           Read();
           */
            #endregion

            #region Ejercicio3
            /*Pedir por pantalla 10 números, que iremos almacenando en un Listado (o 2 como prefiramos). 
             * Al terminar de introducir los números, tendremos que recorrer el/los listados, 
             * diciéndonos cuanto suman los pares y cuando los impares.*/
            /*
                        List<int> listaNumeros = new List<int>();
                        int numeroIntroducido, contadorPares = 0, contadorImpares = 0;

                        for (int i = 0; i < 10; i++)
                        {
                            if (i == 0)
                            {
                                Write("Por favor, introduzca un número: ");
                                numeroIntroducido = ToInt32(ReadLine());
                            }
                            else
                            {
                                Write("Por favor, introduzca otro número: ");
                                numeroIntroducido = ToInt32(ReadLine());
                            }
                            listaNumeros.Add(numeroIntroducido);
                        }

                        foreach (var item in listaNumeros)
                        {
                            if (item % 2 == 0)
                            {
                                contadorPares = contadorPares + item;
                            }
                            else
                            {
                                contadorImpares = contadorImpares + item;
                            }
                        }

                        Write($"Los números pares suman {contadorPares} y los números impares suman {contadorImpares}");

                        Read();
                        /*

                        #endregion

                        #region Ejercicio4
                        /*Crear un programa nos pida introducir 10 números enteros. esos valores los introduciremos en un Listado y  mostraremos 
                         * el numero mayor y menor, consultando los valores en el Listado.*/

            #endregion

            #region Ejercicio5
            /*Usando Arrays, crea un programa que nos pida cuantos elementos tendrá el array, dependiendo de ese numero de elementos, nos ira pidiendo valores, 
             * que introduciremos en el array. una vez introducidos, nos pedirá un nuevo valor a insertar y la posición donde queremos insertarla en el array.*/

            #endregion
        }
    }
}
