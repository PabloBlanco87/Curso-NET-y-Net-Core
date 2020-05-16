using Mod12_CustomExceptions.MisExcepciones;
using System;

namespace Mod12_CustomExceptions
{

    //Hay que crear una clase que derive de ApplicationException para hacer Custom Exceptions
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //bloque de código
                int variable = Ejemplo();

            }
            catch (MyException ex)
            {
                //capturamos la excepcion
                Console.WriteLine(ex.Message);

            }
            finally
            {
                //siempre se ejecuta
            }

            Console.Read();
        }

        public static int Ejemplo()
        {
            try
            {
                //bloque de código
                object obj = "aa";
                int variable = (int)obj;

            }
            catch (Exception ex)
            {
                //capturamos la excepcion y hacemos una devolución de un valor, en lugar de lanzar una excepcion

                //tambien se puede esto:
                throw new MyException();
            }

            return 1;

        }
    }
}
