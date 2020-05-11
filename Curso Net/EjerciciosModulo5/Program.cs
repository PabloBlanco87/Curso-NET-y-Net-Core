using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace EjerciciosModulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio1
            //Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.

            var valor = PideCambio();
            PideMoneda(valor);
            Read();
            #endregion

            #region Ejercicio2
            /*Crear una calculadora , usando funciones de suma, resta, multiplicación y división.
             * Se creara un menú por consola, de la siguiente forma:
             * 1 - Suma
             * 2 - Resta
             * 3 - Multiplicación
             * 4 - División
             * Seleccione la opción: dependiendo de la selección, se pedirán 2 números, y usando las funciones creadas, 
             * devolverá el resultado por consola*/

            var opcion = PintaMenuCalculadora();
            EjecutaOperacion(opcion);
            Read();
            #endregion

            #region Ejercicio3
            /*Se creara un programa que mediante funciones, nos ayude a desglosar un importe introducido por consola, 
             * en el numero mínimo posible de billetes y monedas*/
            double cantidad = IntroduceCantidad();
            Billetes(cantidad);
            Read();
            #endregion

            #region Ejercicio4
            /*Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, 
             * una cifra numérica o una consonante (realizar obligatoriamente 3 funciones, "EsNumero", "EsVocal", "EsConsonante").*/
            char teclaEscogida = IntroduceChar();
            EsNumero(teclaEscogida);
            Read();
            #endregion

            #region Ejercicio5
            //Crear un programa usando funciones, que introduciendo un número por consola, pinte su tabla de multiplicar en la consola
            int numeroEscogido = IntroduceUnNumero();
            TablaMultiplica(numeroEscogido);
            Read();
            #endregion

            #region Ejercicio6
            /*Crea un programa que este preguntando números por consola, hasta que se pulse el numero 0. una vez pulsado el 0 
             * se mostrara la siguiente información:
             * Numero mas alto, numero mas bajo, la diferencia entre el mayor y el menor, cantidad de números introducidos.
             * Usa métodos y funciones y el bucle While para controlar que se introduce el numero 0.*/
            List<int> listaNumerosEscogidos = IngresaNumero();
            DimeDatos(listaNumerosEscogidos);
            Read();

            #endregion
        }

        #region FuncionesEjercicio1
        ///////////////////////
        /// PRIMER EJERCICIO///
        ///////////////////////
        public static double PideCambio()
        {
            WriteLine("Por favor ingrese cuantos dólares vale un euro, por ejemplo 1.26");
            double valor = ToDouble(ReadLine());
            return valor;
        }

        public static void PideMoneda(double valor)
        {
            WriteLine("Si desea cambiar Euros a Dólares, teclee la letra a y pulse enter, " +
                "en caso contrario, teclee la letra b y pulse enter");
            var opcion = ToChar(ReadLine());
            switch (opcion)
            {
                case 'a':
                    PideEuros();
                    break;
                case 'b':
                    PideDolares();
                    break;
            }

            void PideEuros()
            {
                WriteLine("¿Cuántos Euros quiere cambiar?");
                double euros = ToDouble(ReadLine());
                WriteLine(euros + " euros equivalen a " + EurosADolares(euros, valor) + " dólares.");
            }

            void PideDolares()
            {
                WriteLine("¿Cuántos Dólares quiere cambiar?");
                double dolar = ToDouble(ReadLine());
                WriteLine(dolar + " dólares equivalen a " + DolaresAEuros(dolar, valor) + " euros.");

            }
        }

        public static double EurosADolares(double cantidadEuros, double valor)
        {
            return cantidadEuros * valor;
        }

        public static double DolaresAEuros(double cantidadDolares, double valor)
        {
            return cantidadDolares / valor;
        }
        #endregion

        #region FuncionesEjercicio2
        ////////////////////////
        /// SEGUNDO EJERCICIO///
        ////////////////////////
        public static string PintaMenuCalculadora()
        {
            WriteLine("*** CALCULADORA ***");
            WriteLine("*** 1. SUMA ***");
            WriteLine("*** 2. RESTA ***");
            WriteLine("*** 3. MULTIPLICACIÓN ***");
            WriteLine("*** 4. DIVISIÓN ***");
            string opcion = ReadLine();
            return opcion;
        }



        public static void EjecutaOperacion(string opcion)
        {
            WriteLine("Introduzca el primer número y pulse enter");
            double numero1 = ToDouble(ReadLine());
            WriteLine("Introduzca el segundo número y pulse enter");
            double numero2 = ToDouble(ReadLine());
            switch (opcion)
            {
                case "1":
                    WriteLine(numero1 + " + " + numero2 + " = " + Suma(numero1, numero2));
                    break;
                case "2":
                    WriteLine(numero1 + " - " + numero2 + " = " + Resta(numero1, numero2));
                    break;
                case "3":
                    WriteLine(numero1 + " * " + numero2 + " = " + Multiplicacion(numero1, numero2));
                    break;
                case "4":
                    WriteLine(numero1 + " / " + numero2 + " = " + Division(numero1, numero2));
                    break;
            }
        }

        public static double Suma(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Resta(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
        #endregion

        #region FuncionesEjercicio3
        ////////////////////////
        /// TERCER EJERCICIO////
        ////////////////////////

        public static double IntroduceCantidad()
        {
            Write("Por favor, ingrese una cantidad de dinero, por ejemplo 2450,36: ");
            double cantidad = ToDouble(ReadLine());
            return cantidad;
        }

        public static void Billetes(double cantidadDinero)
        {
            int contador500 = 0, contador200 = 0, contador100 = 0, contador50 = 0, contador20 = 0, contador10 = 0, contador5 = 0,
                contador2 = 0, contador1 = 0, contador050 = 0, contador020 = 0, contador010 = 0, contador005 = 0, contador001 = 0;

            while ((cantidadDinero / 500) >= 1)
            {
                cantidadDinero = cantidadDinero - 500;
                contador500++;
            }
            while ((cantidadDinero / 200) >= 1)
            {
                cantidadDinero = cantidadDinero - 200;
                contador200++;
            }
            while ((cantidadDinero / 100) >= 1)
            {
                cantidadDinero = cantidadDinero - 100;
                contador100++;
            }
            while ((cantidadDinero / 50) >= 1)
            {
                cantidadDinero = cantidadDinero - 50;
                contador50++;
            }
            while ((cantidadDinero / 20) >= 1)
            {
                cantidadDinero = cantidadDinero - 20;
                contador20++;
            }
            while ((cantidadDinero / 10) >= 1)
            {
                cantidadDinero = cantidadDinero - 10;
                contador10++;
            }
            while ((cantidadDinero / 5) >= 1)
            {
                cantidadDinero = cantidadDinero - 5;
                contador5++;
            }

            Monedas(cantidadDinero);

            ImprimeBilletes500(contador500);
            ImprimeBilletes200(contador200);
            ImprimeBilletes100(contador100);
            ImprimeBilletes50(contador50);
            ImprimeBilletes20(contador20);
            ImprimeBilletes10(contador10);
            ImprimeBilletes5(contador5);
            ImprimeMonedas2(contador2);
            ImprimeMonedas1(contador1);
            ImprimeMonedas050(contador050);
            ImprimeMonedas020(contador020);
            ImprimeMonedas010(contador010);
            ImprimeMonedas005(contador005);
            ImprimeMonedas001(contador001);

            void Monedas(double cantidadMonedas)
            {
                while ((cantidadMonedas / 2) >= 1)
                {
                    cantidadMonedas = cantidadMonedas - 2;
                    contador2++;
                }
                while ((cantidadMonedas / 1) >= 1)
                {
                    cantidadMonedas = cantidadMonedas - 1;
                    contador1++;
                }
                while ((cantidadMonedas / 0.5) >= 1)
                {
                    cantidadMonedas = cantidadMonedas - 0.5;
                    contador050++;
                }
                while ((cantidadMonedas / 0.2) >= 1)
                {
                    cantidadMonedas = cantidadMonedas - 0.2;
                    contador020++;
                }
                while ((cantidadMonedas / 0.1) >= 1)
                {
                    cantidadMonedas = cantidadMonedas - 0.1;
                    contador010++;
                }
                while ((cantidadMonedas / 0.05) >= 1)
                {
                    cantidadMonedas = cantidadMonedas - 0.05;
                    contador005++;
                }
                while ((cantidadMonedas / 0.01) >= 1)
                {
                    cantidadMonedas = cantidadMonedas - 0.01;
                    contador001++;
                }
            }

        }

        public static void ImprimeBilletes500(int numeroDeBilletes)
        {
            if (numeroDeBilletes != 0)
            {
                WriteLine("Billetes de 500: " + numeroDeBilletes);
            }
        }
        public static void ImprimeBilletes200(int numeroDeBilletes)
        {
            if (numeroDeBilletes != 0)
            {
                WriteLine("Billetes de 200: " + numeroDeBilletes);
            }
        }
        public static void ImprimeBilletes100(int numeroDeBilletes)
        {
            if (numeroDeBilletes != 0)
            {
                WriteLine("Billetes de 100: " + numeroDeBilletes);
            }
        }
        public static void ImprimeBilletes50(int numeroDeBilletes)
        {
            if (numeroDeBilletes != 0)
            {
                WriteLine("Billetes de 50: " + numeroDeBilletes);
            }
        }
        public static void ImprimeBilletes20(int numeroDeBilletes)
        {
            if (numeroDeBilletes != 0)
            {
                WriteLine("Billetes de 20: " + numeroDeBilletes);
            }
        }
        public static void ImprimeBilletes10(int numeroDeBilletes)
        {
            if (numeroDeBilletes != 0)
            {
                WriteLine("Billetes de 10: " + numeroDeBilletes);
            }
        }
        public static void ImprimeBilletes5(int numeroDeBilletes)
        {
            if (numeroDeBilletes != 0)
            {
                WriteLine("Billetes de 5: " + numeroDeBilletes);
            }
        }
        public static void ImprimeMonedas2(int numeroDeMonedas)
        {
            if (numeroDeMonedas != 0)
            {
                WriteLine("Monedas de 2: " + numeroDeMonedas);
            }
        }
        public static void ImprimeMonedas1(int numeroDeMonedas)
        {
            if (numeroDeMonedas != 0)
            {
                WriteLine("Monedas de 1: " + numeroDeMonedas);
            }
        }
        public static void ImprimeMonedas050(int numeroDeMonedas)
        {
            if (numeroDeMonedas != 0)
            {
                WriteLine("Monedas de 50 céntimos: " + numeroDeMonedas);
            }
        }
        public static void ImprimeMonedas020(int numeroDeMonedas)
        {
            if (numeroDeMonedas != 0)
            {
                WriteLine("Monedas de 20 céntimos: " + numeroDeMonedas);
            }
        }
        public static void ImprimeMonedas010(int numeroDeMonedas)
        {
            if (numeroDeMonedas != 0)
            {
                WriteLine("Monedas de 10 céntimos: " + numeroDeMonedas);
            }
        }
        public static void ImprimeMonedas005(int numeroDeMonedas)
        {
            if (numeroDeMonedas != 0)
            {
                WriteLine("Monedas de 5 céntimos: " + numeroDeMonedas);
            }
        }
        public static void ImprimeMonedas001(int numeroDeMonedas)
        {
            if (numeroDeMonedas != 0)
            {
                WriteLine("Monedas de 1 céntimo: " + numeroDeMonedas);
            }
        }
        #endregion

        #region FuncionesEjercicio4
        ////////////////////////
        /// CUARTO EJERCICIO////
        ////////////////////////

        public static char IntroduceChar()
        {
            Write("Por favor introduzca una letra o un número y pulse enter: ");
            char tecla = ToChar(ReadLine());
            return tecla;
        }

        public static void EsNumero(char teclaEscogida)
        {
            if (teclaEscogida.Equals('1') || teclaEscogida.Equals('2') || teclaEscogida.Equals('3') || teclaEscogida.Equals('4')
                || teclaEscogida.Equals('5') || teclaEscogida.Equals('6') || teclaEscogida.Equals('7')
                || teclaEscogida.Equals('8') || teclaEscogida.Equals('9') || teclaEscogida.Equals('0'))
            {
                WriteLine("La tecla pulsada " + teclaEscogida + " es un número");
            }
            else
            {
                EsVocal(teclaEscogida);
            }

            void EsVocal(char tecla)
            {
                if (tecla == 'a' || tecla == 'e' || tecla == 'i' || tecla == 'o' || tecla == 'u')
                {
                    WriteLine("La tecla pulsada " + tecla + " es una vocal");
                }
                else
                {
                    EsConsonante(tecla);
                }

                void EsConsonante(char teclaSeleccionada)
                {
                    WriteLine("La tecla pulsada " + teclaSeleccionada + " es una consonante");
                }
            }
        }

#endregion

        #region FuncionesEjercicio5
        ////////////////////////
        /// QUINTO EJERCICIO////
        ////////////////////////

        public static int IntroduceUnNumero()
        {
            Write("Por favor introduzca un número: ");
            int numero = ToInt32(ReadLine());
            return numero;
        }

        public static void TablaMultiplica(int recibeNumero)
        {
            for (int i = 0; i <= 10; i++)
            {
                WriteLine(recibeNumero + " x " + i + " = " + (recibeNumero * i));
            }
        }
        #endregion

        #region FuncionesEjercicio6

        ////////////////////////
        /// SEXTO EJERCICIO ////
        ////////////////////////

        public static List<int> IngresaNumero()
        {
            List<int> listaNumeros = new List<int>();
            int numero = 0;

            do
            {
                WriteLine("Por favor ingrese un número, para salir, pulse 0: ");
                numero = ToInt32(ReadLine());
                if (numero != 0)
                {
                    listaNumeros.Add(numero);
                }
            } while (numero != 0);

            return listaNumeros;
        }


        public static void DimeDatos(List<int> lista)
        {
            int numeroMayor = BuscaMayor(lista);
            int numeroMenor = BuscaMenor(lista);
            int diferencia = Diferencia(numeroMayor, numeroMenor);
            ImprimeDatos(numeroMayor, numeroMenor, diferencia);

            int BuscaMayor(List<int> listaMayor)
            {
                int mayor = 0;
                listaMayor.ForEach(delegate (int numero)
                {
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                });
                return mayor;
            }

            int BuscaMenor(List<int> listaMenor)
            {
                int menor = lista[0];
                lista.ForEach(delegate (int numero)
                {
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                });
                return menor;
            }

            int Diferencia(int numero1, int numero2)
            {
                int resultado;
                if (numero1 > numero2)
                {
                    resultado = numero1 - numero2;
                }
                else
                {
                    resultado = numero2 - numero1;
                }
                return resultado;
            }

            void ImprimeDatos(int mayor, int menor, int resto)
            {
                WriteLine("El número mayor es: " + mayor);
                WriteLine("El número menor es: " + menor);
                WriteLine("La diferencia entre ambos números es: " + resto);
            }
        }

        #endregion
    }
}