using System;

namespace Mod12_IntroduccionExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //bloque de código
                //object obj = "aa";
                //int variable = (int)obj;
                var numero= Ejemplo();

            }
            catch (OutOfMemoryException ex)
            {
                //capturamos la excepcion
            }
            catch (DivideByZeroException ex)
            {
                //capturamos la excepcion
            }
            catch (InvalidCastException ex)
            {
                //capturamos la excepcion
            }
            catch (Exception ex)
            {
                //capturamos la excepcion
            }
            finally
            {
                //siempre se ejecuta aunque no haya entrado en un catch
            }

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
                return 0;   //No devuelve un error, si no un 0

                //tambien se puede esto:
                throw ex;
            }
            finally
            {
                //siempre se ejecuta
            }

            return 1;
        }
    }
}
