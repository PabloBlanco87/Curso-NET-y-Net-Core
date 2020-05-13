using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    public class Vehiculo
    {
        public int Ruedas;
        public int PuertasPrivadas;

        public Vehiculo() => (Ruedas, PuertasPrivadas) = (4, 5);

        public Vehiculo(int ruedas) => (Ruedas, PuertasPrivadas) = (ruedas, 5);

        public Vehiculo(int ruedas, int puertasPrivadas) => (Ruedas, PuertasPrivadas) = (ruedas, puertasPrivadas);

    }
}
