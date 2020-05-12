using System;

namespace Clases_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //La clase es la plantilla que contiene tanto variables como métodos que nos hacen cambiar el estado de esas variables
            //Los objetos son las instancias que se crean de cada clase

            CuentaBancaria cuenta1 = new CuentaBancaria();  //Esto es una instancia de cuenta bancaria
            CuentaBancaria cuenta2 = new CuentaBancaria();  //Esto es otra instancia completamente diferente a la anterior

            cuenta1.Saldo = 1500;
            cuenta2.Saldo = 2200;

            int suma = cuenta1.Saldo + cuenta2.Saldo;


        }
    }
}
