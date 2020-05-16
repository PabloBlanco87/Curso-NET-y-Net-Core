using System;
using System.IO;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mod11_Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todos> ejemplo1 = new List<Todos>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://jsonplaceholder.typicode.com/todos");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();

                //para poder utilizar el JsonConvert es necesario agregar Nuget llamado Newtonsoft.Json
                ejemplo1 = JsonConvert.DeserializeObject<List<Todos>>(json);
                Console.WriteLine("El ejemplo es: " + ejemplo1.First().title);
            }

            foreach (var item in ejemplo1)
            {
                Console.WriteLine(item.title);
            }

            //Para deserializarlo:

            var serializado = JsonConvert.SerializeObject(ejemplo1);

            Console.ReadLine();
        }
    }
}
