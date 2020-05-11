using System;
using System.Text;
using static System.Console;

namespace EjerciciosModulo6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio1
            /*Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Alejandro", 
             * o bien le diga "No te conozco" si teclea otro nombre. tener en cuenta, que el la validación no es case sensitive,
             * es decir que si escriben "alejandro" ,"Alejandro", "aleJANdrO" serán valores validos. */
            /*      string nombreIntroducido = RecibeNombre();
                  CompruebaNombre(nombreIntroducido);
                  Read();
      */
            #endregion

            #region Ejercicio2
            //Escribir un programa que pida una palabra, y la escriba a su inversa, por ejemplo si se introduce Paris, devolverá "Sirap".
            /*  string palabraSeleccionada = PidePalabra();
                CadenaInversa(palabraSeleccionada);
                Read();
                */
            #endregion

            #region Ejercicio3
            /*Crea un programa que pida una frase de al menos 20 caracteres y al menos 4 palabras por consola y se muestre la 
             * siguiente información de esa cadena(usa funciones para cada caso), se deberá validar que la cadena tiene al 
             * menos 20 caracteres y la frase consta al menos de 4 palabras
             * A) longitud de la cadena
             * B) pinta la cadena, remplazando la letra "a" por "x", la "A" podrá ser mayúscula o minúscula en cuyo caso si es "a" se 
             * cambiara por una "x" y si es "A" se cambiara por una "X"
             * C) pinta la cadena en mayúsculas
             * D) pinta la cadena en minúsculas
             * E) pinta la cadena, removiendo las 3 primeras letras
             * F) pinta la cadena, extrayendo las letras en las posiciones de la 5 a la 10
             * G)invierte la cadena
             * H)escribe el numero de palabras que tiene la frase
             * I)escribe únicamente la tercera palabra*/

            /*  string frase = PideFrase();
              DimeLongitud(frase);
              CambiaAPorX(frase);
              CambiaMayusculas(frase);
              CambiaMinusculas(frase);
              Borra3Primeras(frase);
              ExtraeSubcadena(frase);
              CadenaInversa(frase);   //Recupero función del ejercicio2 (reutilizamos código)
              NumeroPalabras(frase);
              DimeTerceraPalabra(frase);
              Read();
  */
            #endregion

            #region Ejercicio4
            /*Escribir un programa que pida 4 números por consola, y escriba la siguiente frase, 
             * "El primer numero introducido es el <numero1> , despues han introducido el <numero2> y <numero3> y por ultimo el <numero4>"  
             * utilizar StringBuilder para realizar el ejercicio.*/
            /*          ConstruyeFrase();
                      Read();
          */
            #endregion

            #region Ejercicio5
            //Crear un programa que muestre las letras de la Z(mayúscula) a la A(mayúscula, descendiendo)
            MuestraAbecedario();
            Read();
            #endregion

        }

        #region FuncionesEjercicio1
        public static string RecibeNombre()
        {
            Write("Por favor, introduzca su nombre: ");
            string nombre = ReadLine();
            nombre = nombre.ToLower();
            return nombre;
        }

        public static void CompruebaNombre(string nombreUsuario)
        {
            string alejandro = "alejandro";
            while (nombreUsuario != alejandro)
            {
                nombreUsuario = RecibeNombre();
            }
            WriteLine("Hola!");
        }
        #endregion

        #region FuncionesEjercicio2
        public static string PidePalabra()
        {
            Write("Ingrese una palabra y pulse enter: ");
            string palabraIntroducida = ReadLine();
            return palabraIntroducida;
        }

        public static void CadenaInversa(string palabra)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = (palabra.Length - 1); i >= 0; i--)
            {
                sb.Append(palabra[i]);
            }
            WriteLine($"La palabra invertida es: {sb}");
        }
        #endregion

        #region FuncionesEjercicio3
        public static string PideFrase()
        {
            WriteLine("Ingrese una frase y pulse enter: ");
            string fraseIntroducida = ReadLine();
            int contadorPalabras = 0;
            bool flag = true;

            while (contadorPalabras < 4 || fraseIntroducida.Length < 20)
            {
                if (!flag)
                {
                    WriteLine("La frase debe contener al menos 4 palabras y 20 caracteres, pruebe de nuevo: ");
                    fraseIntroducida = ReadLine();
                }

                flag = false;
                contadorPalabras = 0;
                foreach (var letra in fraseIntroducida)
                {
                    if (letra.Equals(' '))
                    {
                        contadorPalabras++;
                    }
                }
            }
            WriteLine("¡Perfecto!");
            return fraseIntroducida;
        }

        public static void DimeLongitud(string frase)
        {
            WriteLine($"Longitud de la cadena: {frase.Length} caracteres");
        }

        public static void CambiaAPorX(string frase)
        {
            frase = frase.Replace('a', 'x');
            frase = frase.Replace('A', 'X');
            WriteLine(frase);
        }

        public static void CambiaMayusculas(string frase)
        {
            WriteLine(frase.ToUpper());
        }

        public static void CambiaMinusculas(string frase)
        {
            WriteLine(frase.ToLower());
        }

        public static void Borra3Primeras(string frase)
        {
            frase = frase.Remove(0, 3);
            WriteLine(frase);
        }

        public static void ExtraeSubcadena(string frase)
        {
            frase = frase.Substring(5, 10);
            WriteLine(frase);
        }

        public static void NumeroPalabras(string frase)
        {
            int contadorPalabras = 1;
            foreach (var item in frase)
            {
                if (item.Equals(' '))
                {
                    contadorPalabras++;
                }
            }
            WriteLine($"La frase tiene {contadorPalabras} palabras");
        }

        public static void DimeTerceraPalabra(string frase)
        {
            int contadorLetras = 0, contadorEspacios = 0, inicioPalabra = 0, finPalabra = 0;

            foreach (var item in frase)
            {
                if (item.Equals(' '))
                {
                    contadorEspacios++;
                    if (contadorEspacios == 2)
                    {
                        inicioPalabra = (contadorLetras + 1);
                    }
                }

                if (contadorEspacios == 3)
                {
                    finPalabra = contadorLetras - inicioPalabra;
                    break;
                }
                contadorLetras++;
            }

            frase = frase.Substring(inicioPalabra, finPalabra);
            WriteLine(frase);
        }
        #endregion

        #region FuncionesEjercicio4
        public static void ConstruyeFrase()
        {
            int i;
            StringBuilder sb = new StringBuilder();
            for (i = 0; i < 4; i++)
            {
                Write($"Por favor, introduzca el {i + 1}º número: ");
                string numero = ReadLine();
                if (i == 0)
                {
                    sb.Append($"El primer numero introducido es el {numero}, ");
                }
                if (i == 1)
                {
                    sb.Append($"despues han introducido el {numero} ");
                }
                if (i == 2)
                {
                    sb.Append($"y {numero} ");
                }
                if (i == 3)
                {
                    sb.Append($"y por ultimo el {numero}");
                }
            }

            WriteLine(sb);
        }

        #endregion

        #region FuncionesEjercicio5
        public static void MuestraAbecedario()
        {
            string abecedario = "abcdefghijklmnopqrstuvwxyz";
            abecedario = abecedario.ToUpper();
            for (int i = abecedario.Length-1; i >= 0; i--)
            {
                Write($"{abecedario[i]} ");
            }
        }

        #endregion
    }
}
