using System;

namespace ClaseAbstractaVSInterfaces

    //Las clases abstractas nos permite añadir algo de funcionalidad por ejemplo el método mover, interfaz tienes que crear todo
{
    public abstract class Vehiculo
    {
        public void Mover(int ruedas)
        {
            Console.WriteLine("Moviendo {0} ruedas", Ruedas);
        }

        public abstract int Ruedas { get; }
    }

    public class Coche : Vehiculo
    {
        public override int Ruedas
        {
            get { return 4; }
        }
    }

    public class Bicicleta : Vehiculo
    {
        public override int Ruedas
        {
            get { return 2; }
        }
    }


    public interface IVehiculos
    {
        void Mover();
        int Ruedas { get; }
    }

    public class CocheI : IVehiculos
    {
        public int Ruedas
        {
            get { return 4; }
        }

        public void Mover()
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Bicicleta bici = new Bicicleta();
            bici.Mover(bici.Ruedas);
        }
    }
}
