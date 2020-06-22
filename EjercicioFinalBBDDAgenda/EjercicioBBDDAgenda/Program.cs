using EjercicioBBDDAgenda.Clases;
using EjercicioBBDDAgenda.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using static System.Console;
using static System.Convert;

namespace EjercicioBBDDAgenda
{
    class Program
    {

        static void Main(string[] args)
        {
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
            WriteLine();
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

        public static void AddContacto()
        {
            Write("Introduzca un nombre: ");
            string nombre = ReadLine();
            Write("Introduzca un apellido: ");
            string apellido = ReadLine();
            Write("Introduzca un teléfono: ");
            int telefono = ToInt32(ReadLine());
            Write("Introduzca una localidad: ");
            string localidad = ReadLine();

            using (var context = new AgendaContext())
            {
                var contacto = new Contacto()
                {
                    Nombre = nombre,
                    Apellidos = apellido,
                    Telefono = telefono,
                    Localidad = localidad
                };
                context.Add<Contacto>(contacto);
                context.SaveChanges();
            }
        }

        public static void MuestraContactos()
        {
            Write("Por favor, introduzca un nombre de usuario a buscar: ");
            var eleccion = ReadLine();
            var context = new AgendaContext();
            var listaContactos = context.Contactos.Where(x => x.Nombre.Contains(eleccion)).ToList();
            if (listaContactos.Count == 0)
            {
                WriteLine("No se encuentra ningún contacto, debe crearlo antes de añadir la cita");
                AddContacto();
            }
            else
            {
                foreach (var item in listaContactos)
                {
                    WriteLine($"-{item.Nombre} {item.Apellidos}. Teléfono:{item.Telefono}. Localidad: {item.Localidad}.");
                }
            }
        }

        public static void ConsultaCita()
        {
            WriteLine("¿Cómo desea realizar la consulta?{0}1. Consulta por fecha{0}2. Consulta por contacto{0}", Environment.NewLine);
            var eleccion = ToInt32(ReadLine());
            var context = new AgendaContext();
            if (eleccion == 1)
            {
                Write("Introduzca una fecha (formato: dd/mm/aaaa):");
                var fechaEscogida = ReadLine();
                var listaCitas = context.Citas.Where(x => x.Fecha == fechaEscogida).ToList();
                if (listaCitas.Count == 0)
                {
                    WriteLine("No se encuentran citas para la fecha indicada");
                }
                else
                {
                    foreach (var item in listaCitas)
                    {
                        WriteLine($"Fecha:{ item.Fecha} Hora:{item.Hora} Asunto:{item.Descripcion} {GetContacto(item.ContactoId)}");
                    }
                }
            }
            else if (eleccion == 2)
            {
                Write("Introduzca un nombre: ");
                var nombreEscogido = ReadLine();

                var contexto = new AgendaContext();
                var listaContactos = context.Contactos.Where(x => x.Nombre == nombreEscogido).ToList();
                if (listaContactos.Count == 0)
                {
                    WriteLine("No se encuentran citas para la fecha indicada");
                }
                else if (listaContactos.Count == 1)
                {
                    var citasContacto = context.Citas.Where(x => x.ContactoId == listaContactos[0].ContactoID).ToList();
                    foreach (var item in citasContacto)
                    {
                        WriteLine($"Fecha:{ item.Fecha} Hora:{item.Hora} Asunto:{item.Descripcion}");
                    }
                }
                else
                {
                    foreach (var item in listaContactos)
                    {
                        WriteLine($"Identificador:{item.ContactoID}. Nombre:{item.Nombre} {item.Apellidos}.");
                    }
                    WriteLine();
                    WriteLine("Introduzca el identificador del usuario con el que desea consultar sus citas: ");
                    var identificador = ToInt32(ReadLine());
                    var citasContacto = context.Citas.Where(x => x.ContactoId == identificador).ToList();
                    if (citasContacto.Count == 0)
                    {
                        WriteLine("No hay concertadas citas con dicho contacto");
                    }
                    else
                    {
                        foreach (var item in citasContacto)
                        {
                            WriteLine($"Fecha:{ item.Fecha} Hora:{item.Hora} Asunto:{item.Descripcion}");
                        }
                    }
                }
            }
            else
            {
                WriteLine("Introduzca una opción válida");
            }

        }

        public static string GetContacto(int id)
        {
            string frase = string.Empty;
            var context = new AgendaContext();
            var listaContactos = context.Contactos.Where(x => x.ContactoID == id).ToList();
            foreach (var item in listaContactos)
            {
                frase = ($"Nombre: {item.Nombre} {item.Apellidos}.");
            }
            return frase;
        }

        public static void AddCita()
        {
            Write("Por favor, introduzca un nombre de usuario a buscar: ");
            var eleccion = ReadLine();
            var context = new AgendaContext();
            var listaContactos = context.Contactos.Where(x => x.Nombre.Contains(eleccion)).ToList();
            if (listaContactos.Count == 0)
            {
                WriteLine("No se encuentra ningún contacto");
            }
            else
            {
                foreach (var item in listaContactos)
                {
                    WriteLine($"Identificador: {item.ContactoID}. {item.Nombre} {item.Apellidos}.");
                }

                Write("Introduzca el identificador del usuario con el que desee concretar la cita: ");
                int id = ToInt32(ReadLine());
                Write("Introduzca una fecha (formato: dd/mm/aaaa): ");
                string fecha = ReadLine();
                Write("Introduzca una hora (formato: hh:mm): ");
                string hora = ReadLine();
                Write("Introduzca una descripción de la cita: ");
                string descripcion = ReadLine();

                using (context)
                {
                    var cita = new Cita()
                    {
                        Fecha = fecha,
                        Hora = hora,
                        Descripcion = descripcion,
                        ContactoId = id
                    };
                    context.Add<Cita>(cita);
                    context.SaveChanges();
                }
            }
        }

        public static void EscogeOpcion(int eleccion)
        {
            switch (eleccion)
            {
                case 1:
                    AddCita();
                    break;
                case 2:
                    AddContacto();
                    break;
                case 3:
                    ConsultaCita();
                    break;
                case 4:
                    MuestraContactos();
                    break;
                default:
                    break;
            }
        }
    }

}
