using System;
using System.IO;
using static System.Console;
using static System.Convert;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace EjercicioFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsAbrirAgenda = new FileStream("agenda.txt", FileMode.OpenOrCreate);
            fsAbrirAgenda.Close();
            FileStream fsAbrirContactos = new FileStream("contactos.txt", FileMode.OpenOrCreate);
            fsAbrirContactos.Close();
            int eleccion;

            do
            {
                eleccion = ImprimeMenu();
                EscogeOpcion(eleccion);

            } while (eleccion != 0);

            ReadKey();
        }

        public static int ImprimeMenu()
        {
            int eleccion;
            WriteLine("****** MENÚ ******");
            WriteLine("*** 1. AÑADIR CITA ***");
            WriteLine("*** 2. AÑADIR CONTACTO ***");
            WriteLine("*** 3. CONSULTAR CITA ***");
            WriteLine("*** 4. BUSCAR CONTACTO ***");
            WriteLine("*** 0. SALIR ***");
            Write("Seleccione la opción que desee: ");
            eleccion = ToInt32(ReadLine());
            while (eleccion != 1 && eleccion != 2 && eleccion != 3 && eleccion != 4 && eleccion != 0)
            {
                Write("Debe seleccionar una opción correcta: ");
                eleccion = ToInt32(ReadLine());
            }
            WriteLine();
            return eleccion;
        }

        public static void EscogeOpcion(int opcionEscogida)
        {
            switch (opcionEscogida)
            {
                case 1:
                    AgregaCita();
                    break;
                case 2:
                    CreaPersona();
                    break;
                case 3:
                    int eleccion = EscogeCita();
                    ConsultaCita(eleccion);
                    break;
                case 4:
                    BuscaContacto();
                    break;
                default:
                    break;
            }
        }

        public static byte[] LeeFileStreamContactos()
        {
            FileStream fsLeer = new FileStream("contactos.txt", FileMode.Open);
            byte[] buffer = new byte[5000000];
            fsLeer.Read(buffer, 0, (int)fsLeer.Length);
            fsLeer.Close();
            return buffer;
        }

        public static byte[] LeeFileStreamAgenda()
        {
            FileStream fsLeer = new FileStream("agenda.txt", FileMode.Open);
            byte[] buffer = new byte[5000000];
            fsLeer.Read(buffer, 0, (int)fsLeer.Length);
            fsLeer.Close();
            return buffer;
        }

        public static void EscribeFileStreamAgenda(string id, string date, string hour, string description, string name, string surname)
        {
            FileStream fsCreaPersona = new FileStream("agenda.txt", FileMode.Append);
            string cadena = $"{id}|{date}|{hour}|{description}|{name}|{surname};";
            fsCreaPersona.Write(ASCIIEncoding.ASCII.GetBytes(cadena));
            fsCreaPersona.Close();
        }

        public static void EscribeFileStreamContactos(List<string> lista, string name, string surname, string phone, string location)
        {
            FileStream fsCreaPersona = new FileStream("contactos.txt", FileMode.Append);
            string cadena = $"{lista.Count + 1}|{name}|{surname}|{phone}|{location};";
            fsCreaPersona.Write(ASCIIEncoding.ASCII.GetBytes(cadena));
            fsCreaPersona.Close();
        }

        public static List<string> DivideRegistros(byte[] buffer)
        {
            string cadena = ASCIIEncoding.ASCII.GetString(buffer);
            List<string> lista = cadena.Split(';').ToList();
            lista.RemoveAt(lista.Count - 1);
            return lista;
        }

        public static string Confirma()
        {
            string confirma = string.Empty;

            while (confirma != "s" && confirma != "n")
            {
                Write("Introduzca S o N: ");
                confirma = ReadLine().ToLower();
            }
            return confirma;
        }

        public static void CreaPersona()
        {
            string nombre, apellidos, telefono, localidad, confirma;

            Write("Ingrese el nombre: ");
            nombre = ReadLine();
            Write("Ingrese los apellidos: ");
            apellidos = ReadLine();
            Write("Ingrese el teléfono: ");
            telefono = ReadLine();
            Write("Ingrese la localidad: ");
            localidad = ReadLine();
            WriteLine();

            Write($"Nombre:{nombre}, Apellidos:{apellidos}, Teléfono:{telefono}, Localidad:{localidad}. ¿Desea confirmar?");          

            confirma = Confirma();

            if (confirma == "s")
            {
                byte[] buffer = LeeFileStreamContactos();
                List<string> listaPersonas = DivideRegistros(buffer);

                foreach (var item in listaPersonas)
                {
                    Persona persona = ConstruyePersonas(item);
                }

                EscribeFileStreamContactos(listaPersonas, nombre, apellidos, telefono, localidad);
            }

        }

        public static void AgregaCita()
        {
            string cadena = string.Empty, fecha, hora, descripcion, nombreBuscado, confirma, identificadorPersona;

            bool flag = false;
            Persona personaEscogida;

            Write("Ingrese la fecha en este formato (dd/mm/aaaa): ");
            fecha = ReadLine();
            Write("Ingrese la hora en este formato (hh:mm): ");
            hora = ReadLine();
            Write("Añada una descripción de la cita: ");
            descripcion = ReadLine();
            Write("Ingrese el nombre de la persona con la que tiene la cita: ");
            nombreBuscado = ReadLine();
            WriteLine();

            byte[] buffer = LeeFileStreamContactos();

            List<string> listaPersonas = DivideRegistros(buffer);

            foreach (var item in listaPersonas)
            {
                Persona persona = ConstruyePersonas(item);
                if (nombreBuscado == persona.Nombre)
                {
                    flag = true;
                    WriteLine($"{persona.Id}- {persona.Nombre} {persona.Apellidos}.");
                }
            }

            if (flag)
            {
                WriteLine();
                Write("Introduzca el número identificador de la persona con la que desea tener la reunión: ");
                identificadorPersona = ReadLine();

                foreach (var item in listaPersonas)
                {
                    Persona persona2 = ConstruyePersonas(item);
                    if (identificadorPersona == persona2.Id)
                    {
                        flag = true;
                        cadena = $"{persona2.Id}|{persona2.Nombre}|{persona2.Apellidos}|{persona2.Telefono}|{persona2.Localidad}";
                    }
                }

                personaEscogida = ConstruyePersonas(cadena);
                WriteLine();
                Write($"Cita el {fecha}, a las {hora}, con {personaEscogida.Nombre} {personaEscogida.Apellidos}, motivo: {descripcion}. ¿Desea confirmar?");

                confirma = Confirma();

                if (confirma == "s")
                {
                    EscribeFileStreamAgenda(personaEscogida.Id, fecha, hora, descripcion, personaEscogida.Nombre, personaEscogida.Apellidos);
                }
            }
            else
            {
                WriteLine();
                WriteLine("¡ERROR! Es necesario que se cree el contacto EN PRIMER LUGAR y después la cita.");
                CreaPersona();
            }
        }

        public static int EscogeCita()
        {
            int eleccion;
            WriteLine("*** 1. CONSULTA POR FECHA ***");
            WriteLine("*** 2. CONSULTA POR CONTACTO ***");
            eleccion = ToInt32(ReadLine());
            while (eleccion != 1 && eleccion != 2)
            {
                Write("Debe seleccionar una opción correcta: ");
                eleccion = ToInt32(ReadLine());
            }
            WriteLine();
            return eleccion;
        }

        public static void ConsultaCita(int opcionEscogida)
        {
            bool flag = false;

            byte[] buffer = LeeFileStreamAgenda();

            if (opcionEscogida == 1)
            {
                List<string> listaCitas = DivideRegistros(buffer);

                Write("Por favor, introduzca una fecha para consultar (en formato dd/mm/aaaa): ");
                string fechaSeleccionada = ReadLine();

                foreach (var item in listaCitas)
                {
                    Cita cita = ConstruyeCita(item);
                    if (fechaSeleccionada == cita.Fecha)
                    {
                        flag = true;
                        WriteLine("Citas:");
                        WriteLine($"=> Fecha:{cita.Fecha}, Hora:{cita.Hora}, Persona citada:{cita.NombreCita} {cita.ApellidosCita}, Descripción: {cita.Descripcion}");
                    }
                }
                WriteLine();
                if (!flag)
                {
                    WriteLine($"No hay citas para la fecha {fechaSeleccionada}.");
                    WriteLine();
                }
            }
            else
            {
                Write("Ingrese el nombre de la persona con la que tiene la cita: ");
                string nombreBuscado = ReadLine();
                int contador = 0;

                List<string> listaPersonas = DivideRegistros(buffer);

                string comprueba = string.Empty, comprueba2 = string.Empty;

                List<string> lista = new List<string>();
                List<string> lista2 = new List<string>();
                foreach (var item in listaPersonas)
                {

                    Cita cita = ConstruyeCita(item);
                    if (nombreBuscado == cita.NombreCita)
                    {
                        comprueba = $"{cita.IdPersonaCitada}|{cita.Fecha}|{cita.Hora}|{cita.Descripcion}|{cita.NombreCita}|{cita.ApellidosCita}";
                        comprueba2 = $"{cita.IdPersonaCitada}- {cita.NombreCita} {cita.ApellidosCita}.";

                        if (lista.Contains(comprueba))
                        {
                            continue;
                        }
                        else
                        {
                            lista.Add(comprueba);

                            if (!lista2.Contains(comprueba2))
                            {
                                lista2.Add(comprueba2);
                                WriteLine(comprueba2);
                            }
                        }
                        contador++;
                    }
                }

                if (contador > 1)
                {
                    WriteLine();
                    Write("Introduzca el número identificador de la persona con la que desea tener la reunión: ");
                    string identificadorPersona = ReadLine();

                    foreach (var item in lista)
                    {
                        Cita cita = ConstruyeCita(item);
                        if (identificadorPersona == cita.IdPersonaCitada)
                        {
                            WriteLine();
                            WriteLine("Citas:");
                            WriteLine($"=> Fecha:{cita.Fecha}, Hora:{cita.Hora}, Persona citada:{cita.NombreCita} {cita.ApellidosCita}, Descripción: {cita.Descripcion}");
                        }
                    }

                }
                else
                {
                    foreach (var item in listaPersonas)
                    {
                        Cita cita = ConstruyeCita(item);
                        WriteLine();
                        WriteLine("Citas:");
                        WriteLine($"=> Fecha:{cita.Fecha}, Hora:{cita.Hora}, Persona citada:{cita.NombreCita} {cita.ApellidosCita}, Descripción: {cita.Descripcion}");
                    }
                }
            }
        }

        public static void BuscaContacto()
        {
            Write("Ingrese el nombre de la persona: ");
            string nombreBuscado = ReadLine();
            WriteLine();

            byte[] buffer = LeeFileStreamContactos();
            List<string> listaPersonas = DivideRegistros(buffer);

            Persona persona;
            bool flag = false;
            foreach (var item in listaPersonas)
            {
                persona = ConstruyePersonas(item);
                if (persona.Nombre.Contains(nombreBuscado))
                {
                    flag = true;
                    WriteLine($"Id:{persona.Id}- Nombre:{persona.Nombre}, Apellidos:{persona.Apellidos}, Teléfono:{persona.Telefono}, Localidad:{persona.Localidad}.");
                }
            }
            if (flag == false)
            {
                WriteLine("No se encuentra el contacto");
            }
            WriteLine();

        }      

        public static Persona ConstruyePersonas(string linea)
        {
            string[] datosPersona = linea.Split('|');

            return new Persona
            {
                Id = datosPersona[0],
                Nombre = datosPersona[1],
                Apellidos = datosPersona[2],
                Telefono = datosPersona[3],
                Localidad = datosPersona[4],
            };
        }

        public static Cita ConstruyeCita(string linea)
        {
            string[] datosCita = linea.Split('|');

            return new Cita
            {
                IdPersonaCitada = datosCita[0],
                Fecha = datosCita[1],
                Hora = datosCita[2],
                Descripcion = datosCita[3],
                NombreCita = datosCita[4],
                ApellidosCita = datosCita[5]
            };
        }
    }
}
