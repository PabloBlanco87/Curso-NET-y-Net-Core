using System;
using System.Collections.Generic;
using System.Text;

namespace DeclaracionClases
{
    class Clase
    {
        //En el cuerpo de una clase puede haber:

        //***************************************************************
        //Constantes
        const int IVA = 7;
        const int IVA7 = 7, IVA11 = 11, IVA21 = 21;

        private int Importe { get; set; }

        public int CalcularImporte(int importe)
        {
            IVA = 11; //No se puede modificar
            return importe + (importe * IVA);
        }

        //***************************************************************
        //Propiedades o Campos (variables que pertenecen a una clase)
        public int Campo;
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; private set; }
        public int Estado = 1;

        /*Campos de solo lectura, podemos asignarle el valor aquí, o como más abajo, en el constructor, 
         * esa es la diferencia con las constantes*/
        public readonly string Identificador;

        //Constructor
        public Clase()
        {
            Identificador = "ABCD";
            Edad = 21;
        }


        //***************************************************************
        //Métodos
        //Modifican el comportamiento de las clases

        public void Calcular(int edad)
        {
            Console.WriteLine(edad + 15);
        }
        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        //Tipos de acceso: public, private, internal, protected, protected internal (mirar en los recursos)

        //***************************************************************
        //Eventos
        //***************************************************************
        //Indizadores
        //***************************************************************
        //Operadores
        //***************************************************************
        //Constructores
        //***************************************************************
        //Destructores
        //***************************************************************
        //Tipos
    }
}
