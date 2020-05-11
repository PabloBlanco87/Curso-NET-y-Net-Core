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

            ArrayList arrayList = CreaArrayList();
            SumaElementosArray(arrayList);
            Read();

            #endregion

            #region Ejercicio2
            /*Pedir por pantalla 5 nombres, e insertarlo en una Lista (List) una vez insertados, 
             * se pedirá que introduzcamos un nombre, el programa tendrá que decirnos si ese 
             * nombre esta contenido en la lista.*/

            List<string> listaNombres = ConstruyeListaNombres();
            ContieneNombre(listaNombres);
            Read();

            #endregion

            #region Ejercicio3
            /*Pedir por pantalla 10 números, que iremos almacenando en un Listado (o 2 como prefiramos). 
             * Al terminar de introducir los números, tendremos que recorrer el/los listados, 
             * diciéndonos cuanto suman los pares y cuando los impares.*/

            List<int> listaNumeros = ConstruyeListado();
            SumaParOImpar(listaNumeros);
            Read();

            #endregion

            #region Ejercicio4
            /*Crear un programa que nos pida introducir 10 números enteros. esos valores los introduciremos 
             * en un Listado y mostraremos el numero mayor y menor, consultando los valores en el Listado.*/

            List<int> listaNumeros2 = ConstruyeListado();
            DimeMayorYMenor(listaNumeros2);
            Read();

            #endregion

            #region Ejercicio5
            /*Usando Arrays, crea un programa que nos pida cuantos elementos tendrá el array, 
             * dependiendo de ese numero de elementos, nos ira pidiendo valores, que introduciremos 
             * en el array. una vez introducidos, nos pedirá un nuevo valor a insertar y la posición 
             * donde queremos insertarla en el array.*/

            int elementosArray = DimeElementosArray();
            ConstruyeArrayConPosicion(elementosArray);
            Read();

            #endregion
        }

        #region FuncionesEjercicio1
        public static ArrayList CreaArrayList()
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 1; i <= 1000; i++)
            {
                arrayList.Add(i);
            }
            return arrayList;
        }

        public static void SumaElementosArray(ArrayList list)
        {
            int contadorEj1 = 0;
            foreach (int item in list)
            {
                contadorEj1 = contadorEj1 + item;
            }

            WriteLine($"La suma es: {contadorEj1}");
            Read();
        }

        #endregion

        #region FuncionesEjercicio2

        public static List<string> ConstruyeListaNombres()
        {
            List<string> lista = new List<string>();
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
                lista.Add(nombreIntroducido);
                contadorEj2++;
            }
            return lista;
        }

        public static void ContieneNombre(List<string> lista)
        {
            WriteLine("******************************");
            Write("Por favor, introduzca un nombre para ver si se encuentra en la lista: ");
            string nombreIntroducido = ReadLine();

            if (lista.Contains(nombreIntroducido))
            {
                Write($"El nombre {nombreIntroducido} se encuentra en la lista");
            }
            else
            {
                Write($"El nombre {nombreIntroducido} no se encuentra en la lista");
            }
        }

        #endregion

        #region FuncionesEjercicio3
        public static List<int> ConstruyeListado()
        {
            int numeroIntroducido;
            List<int> lista = new List<int>();

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
                lista.Add(numeroIntroducido);
            }

            return lista;
        }

        public static void SumaParOImpar(List<int> lista)
        {
            int contadorPares = 0, contadorImpares = 0;

            foreach (var item in lista)
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
        }

        #endregion

        #region FuncionesEjercicio4

        public static void DimeMayorYMenor(List<int> lista)
        {
            int numeroMayor = lista[0];
            int numeroMenor = lista[0];

            foreach (var item in lista)
            {
                if (item > numeroMayor)
                {
                    numeroMayor = item;
                }
                if (item < numeroMenor)
                {
                    numeroMenor = item;
                }
            }

            Write($"El número mayor es {numeroMayor} y el número menor {numeroMenor}");

        }

        #endregion

        #region FuncionesEjercicio5
        public static int DimeElementosArray()
        {
            Write("Por favor, introduzca cuantos elementos tendrá el array: ");
            int capacidadArray = ToInt32(ReadLine());
            return capacidadArray;
        }

        public static void ConstruyeArrayConPosicion(int numeroElementos)
        {
            ArrayList listaNumeros = new ArrayList();
            string valorIntroducido;
            int posicionArray;

            for (int i = 0; i < numeroElementos; i++)
            {
                Write("Introduzca el valor que quiera: ");
                valorIntroducido = ReadLine();
                Write("¿En qué posición quiere introducirlo? ");
                posicionArray = ToInt32(ReadLine());
                while (posicionArray < 0 || posicionArray > i)
                {
                    WriteLine($"La posición debe estar comprendida entre 0 y {i}, por favor introduzca otra posición:");
                    posicionArray = ToInt32(ReadLine());
                }
                listaNumeros.Insert(posicionArray, valorIntroducido);
            }

            WriteLine($"Finalmente, el array queda así:");
            foreach (var item in listaNumeros)
            {
                Write($" | {item} | ");
            }
        }

        #endregion
    }
}
