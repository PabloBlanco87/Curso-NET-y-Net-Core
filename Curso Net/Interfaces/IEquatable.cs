using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //Las interfaces solo incluyen definiciones definiciones de implementación, no la implementación en sí
    interface IEquatable<T>
    {
        bool Equals(T obj);
        int EsIgual(int numero);
    }

    interface IComparacion
    {
        int EsIgualaCoche(int numero);
    }
}
