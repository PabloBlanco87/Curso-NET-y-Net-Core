using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta
{
    public abstract class ClaseAbstracta
    {
        public abstract int Suma(int i, int z);

        //Método virtual
        public virtual int Resta(int i, int z)
        {
            return i - z;
        }
    }
}
