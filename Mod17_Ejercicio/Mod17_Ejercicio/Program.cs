using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Mod17_Ejercicio
{
    /*Crear un proyecto de API .Net Core 2, y crear las entidades "Colegio" , "Clase", "Profesor" y "Alumno".
     * 
     * Con Entity Framework Core, genera las migraciones y el esquema de la BBDD, para realizar el CRUD de cada entidad.
     * 
     * Se deja en el alumno, como relacionar las entidades entre si.
     * 
     * Puedes usar LocalDB o SQL server de Azure, como prefieras(HE ESCOGIDO AZURE).*/

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
