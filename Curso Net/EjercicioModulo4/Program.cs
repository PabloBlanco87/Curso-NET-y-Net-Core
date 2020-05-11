using System;
using static System.Convert;

namespace EjercicioModulo4
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Ejercicio1
            /*Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica 
             * guardar el valor de la suma de las 3 anteriores. Mostrar por consola.*/
            int numero1 = 2;
            int numero2 = 4;
            int numero3 = 6;
            int resultado = numero1 + numero2 + numero3;
            #endregion

            #region Ejercicio2
            //Pedir dos números al usuario por teclado y decir que número es el mayor.
            Console.WriteLine("Ingrese un número y pulse enter");
            numero1 = ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro número y pulse enter");
            numero2 = ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El número mayor es " + numero1);
            }
            else if (numero1 == numero2)
            {
                Console.WriteLine("Los dos números son iguales");
            }
            else
            {
                Console.WriteLine("El número mayor es " + numero2);
            }
            #endregion

            #region Ejercicio3
            //Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. En caso de error, indicarlo
            Console.WriteLine("Ingrese un día de la semana y pulse enter");
            string dia = Console.ReadLine();
            if (dia == "Lunes" || dia == "Martes" || dia == "Miércoles" || dia == "Jueves" || dia == "Viernes" ||
                dia == "Sábado" || dia == "Domingo")
            {
                switch (dia)
                {
                    case "Sábado":
                        Console.WriteLine("Es fin de semana");
                        break;
                    case "Domingo":
                        Console.WriteLine("Es fin de semana");
                        break;
                    default:
                        Console.WriteLine("Entre semana");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ese día no existe, asegúrese de comenzar la palabra con mayúsculas y poner acentos.");
            }
            #endregion

            #region Ejercicio4
            /*Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) 
             * si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado).*/
            Console.WriteLine("Ingrese el precio del producto que desea comprar");
            int precio = ToInt32(Console.ReadLine());
            if (precio > 0)
            {
                Console.WriteLine("¿Va a pagar con Efectivo o Tarjeta?Ingrese e ó t");
                char formaPago = ToChar(Console.ReadLine());
                if (formaPago == 'e')
                {
                    Console.WriteLine("De acuerdo, pase por caja");
                }
                else if (formaPago == 't')
                {
                    Console.WriteLine("Por favor, ingrese el número de cuenta");
                }
                else
                {
                    Console.WriteLine("No existe dicho método de pago");
                }

            }
            else
            {
                Console.WriteLine("El precio de su artículo debe ser positivo");
            }
            #endregion

            #region Ejercicio5
            //Recorre los números del 1 al 100. Usa un bucle while.
            int numero = 1;
            while (numero >= 1 && numero <= 100)
            {
                Console.WriteLine(numero);
                numero++;
            }
            #endregion

            #region Ejercicio6
            //Recorre los números del 1 al 100. Usa un bucle for.
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region Ejercicio7
            //Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region Ejercicio8
            //Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region Ejercicio9
            //Crea un array e inserta los números pares del 1 al 100 en ese array.
            int[] arrayEnteros = new int[100];
            for (int i = 0; i < arrayEnteros.Length; i++)
            {
                arrayEnteros[i] = i + 1;
            }

            foreach (var item in arrayEnteros)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Ejercicio10
            //Pide 10 números por consola, muestra el resultado por consola de sumar los pares y restarle los impares.
            Console.WriteLine("Buenos días, va a ingresar diez números");

            int pares = 0;
            int impares = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el número " + (i + 1));
                int num = ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    pares = pares + num;
                }
                else
                {
                    impares = impares + num;
                }
            }
            int resultado = pares - impares;
            Console.WriteLine(resultado);
            Console.Read();
            #endregion

            #region Ejercicio11
            /*Crea un programa, que pida un número del 1 al 7,  devuelva el día de la semana , teniendo en cuenta 
             * que el 1 es Lunes, hacer con un switch.*/

            Console.WriteLine("Introduzca un número del 1 al 7 y pulse enter");
            int numero = ToInt32(Console.ReadLine());

            while (numero < 1 || numero > 7)
            {
                Console.WriteLine("El número debe estar comprendido entre 1 y 7");
                numero = ToInt32(Console.ReadLine());
            }

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("El número debe estar comprendido entre 1 y 7");
                    break;
            }

            #endregion

            #region Ejercicio12
            /*Crea un programa que pida por consola un numero del 1 al 1000 (validará que el numero introducido es correcto) 
            y sume todos los números del 1 al numero introducido, mostrando por consola el numero de la suma y la media.*/

            Console.WriteLine("Introduzca un número del 1 al 1000");
            int numero = ToInt32(Console.ReadLine());

            while (numero < 1 || numero > 1000)
            {
                Console.WriteLine("El número debe estar comprendido entre 1 y 1000");
                numero = ToInt32(Console.ReadLine());
            }

            int[] array = new int[numero];
            int sumatorio = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sumatorio = sumatorio + (i + 1);
            }

            Console.WriteLine("La suma de todos sus números es: " + sumatorio);
            Console.WriteLine("La media de sus números es: " + sumatorio / numero);

            #endregion

            #region Ejercicio13
            //Comprobar si un numero introducido por consola es primo
            Console.WriteLine("Por favor, introduzca un número");
            int primo = ToInt32(Console.ReadLine());
            int resto = 0;
            for (int i = 1; i < (primo + 1); i++)
            {
                if (primo % i == 0)
                {
                    resto++;
                }
            }

            if (resto != 2)
            {
                Console.WriteLine("No es primo");
            }
            else
            {
                Console.WriteLine("Es primo");
            }

            Console.Read();

            #endregion

            #region Ejercicio14
            /*Crear un programa calcule cuantas cifras tiene un número entero positivo 
            (pista: se puede hacer dividiendo varias veces entre 10).*/

            Console.WriteLine("Introduzca un número positivo");
            string cadena = Console.ReadLine();
            int numero = ToInt32(cadena);
            while (numero < 0)
            {
                Console.WriteLine("El número introducido es menor que 0, por introduzca un número positivo");
                cadena = Console.ReadLine();
                numero = ToInt32(cadena);
            }

            Console.WriteLine("El número introducido tiene " + cadena.Length + " cifras");
            Console.Read();

            #endregion
        }
    }
}
