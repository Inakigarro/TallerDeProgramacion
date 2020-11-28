using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var db = new AgendaContext())
                {
                    //Alta
                    Persona vPersona = new Persona
                    {
                        PersonaId = 1,
                        Nombre = "Iñaki",
                        Apellido = "Garro",
                        Telefonos = new List<Telefono>
                    {
                        new Telefono
                        {
                            TelefonoId = 1,
                            Numero = "3442480148",
                            Tipo = "Celular"
                        }
                    }
                    };
                    db.Personas.Add(vPersona);
                    db.SaveChanges();

                    foreach (Persona persona in db.Personas)
                    {
                        Console.WriteLine(persona.PersonaId + " " + persona.Nombre + " " + persona.Apellido);
                    }
                }
                Console.WriteLine("Exito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: " + ex);
            }
            Console.ReadKey();           
        }
    }
}
