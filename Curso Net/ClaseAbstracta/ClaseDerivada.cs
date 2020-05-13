using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta
{
    public class ClaseDerivada : Clase
    {
        public override int Resta(int i, int z)
        {
            return i + z;
        }
    }
}
