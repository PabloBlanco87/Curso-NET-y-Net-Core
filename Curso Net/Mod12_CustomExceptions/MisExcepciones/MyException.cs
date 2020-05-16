using System;
using System.Collections.Generic;
using System.Text;

namespace Mod12_CustomExceptions.MisExcepciones
{
    public class MyException : ApplicationException
    {
        public MyException() : base("Esta es mi excepcion")
        {

        }
    }
}
