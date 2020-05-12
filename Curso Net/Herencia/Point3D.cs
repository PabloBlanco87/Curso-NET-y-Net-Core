using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    //Point3D hereda de Point (Point es la clase padre)
    //Point3D hereda todos los elementos públicos y protegidos de la clase padre
    class Point3D : Point
    {
        //Vamos a añadir una funcionalidad nueva

        public int Z { get; private set; }

        public void SetZ(int value)
        {
            if (value < 30)
                Z = value;
            else
                throw new ArgumentOutOfRangeException();
        }

        public int GetZ()
        {
            return Z;
        }
    }
}
