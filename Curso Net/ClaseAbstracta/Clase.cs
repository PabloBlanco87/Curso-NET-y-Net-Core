using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta
{
    public abstract class Clase : ClaseAbstracta
    {
        //En otra clase podemos hacer una implementación que sea completamente diferente
        public override int Suma(int i, int z)
        {
            return i + z;
        }

        //Yo puedo hacer que si alguien hereda de mi, pueda hacer su propia implementación
        public abstract override int Resta(int i, int z);
    }
}
