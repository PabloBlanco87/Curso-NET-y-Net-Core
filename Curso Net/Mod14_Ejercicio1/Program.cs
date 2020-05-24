using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Mod14_Ejercicio1
{
    /*Análogamente a lo visto en este módulo. crea los métodos clases y propiedades ,para crear el código lo más 
     * asincronamente posible,  que ponga como ejemplo hacer una receta de cocina (por ejemplo una tortilla de patatas)
     MI CASO PONER LA MESA*/

    public class Mantel { }
    public class Vaso { }
    public class Cubiertos { }
    public class Servilletas { }
    public class Pan { }
    public class Platos { }

    class Program
    {
        static async Task Main(string[] args)
        {
            int numeroComensales = 4;

            Mantel mantel = PonerMantel();
            Console.WriteLine("Mantel puesto");

            var vasosTask = PonerVasos(numeroComensales);
            var cubiertosTask = PonerCubiertos(numeroComensales);
            var servilletasTask = PonerServilletas(numeroComensales);
            var platosTask = PonerPlatos(numeroComensales);
            var panTask = PonerPanCortado(numeroComensales);

            var allTask = new List<Task> { vasosTask, cubiertosTask, servilletasTask, platosTask, panTask };

            while (allTask.Any())
            {
                Task finished = await Task.WhenAny(allTask);
                if (finished == vasosTask)
                {
                    WriteLine("Vasos colocados");
                    allTask.Remove(vasosTask);
                    var vasos = await vasosTask;
                }
                else if (finished == cubiertosTask)
                {
                    WriteLine("Cubiertos colocados");
                    allTask.Remove(cubiertosTask);
                    var cubiertos = await cubiertosTask;
                }
                else if (finished == servilletasTask)
                {
                    WriteLine("Servilletas colocadas");
                    allTask.Remove(servilletasTask);
                    var cubiertos = await servilletasTask;
                }
                else if (finished == panTask)
                {
                    WriteLine("Panecillos colocados");
                    allTask.Remove(panTask);
                    var cubiertos = await panTask;
                }
                else if (finished == platosTask)
                {
                    WriteLine("Platos colocados");
                    allTask.Remove(platosTask);
                    var cubiertos = await platosTask;
                }
                else
                    allTask.Remove(finished);
            }

            WriteLine("Mesa puesta, ya puede servir la comida");
        }

        public static Mantel PonerMantel()
        {
            return new Mantel();
        }

        async static Task<Vaso> PonerVasos(int numVasos)
        {
            return new Vaso();
        }

        async static Task<Cubiertos> PonerCubiertos(int numCubiertos)
        {
            return new Cubiertos();
        }

        async static Task<Servilletas> PonerServilletas(int numServilletas)
        {
            return new Servilletas();
        }

        async static Task<Platos> PonerPlatos(int numPlatos)
        {
            return new Platos();
        }

        async static Task<Pan> PonerPanCortado(int numPanes)
        {
            var panecillos = await CortarPan(numPanes);
            ColocarPan(panecillos);
            return panecillos;
        }

        async static Task<Pan> CortarPan(int numComensales)
        {
            return new Pan();
        }

        public static void ColocarPan(Pan panIndividual)
        {

        }
    }
}
