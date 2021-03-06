using System;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace Aplicacion.App.PresentacionC
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio de Pruebas!");
            //InsertarPersona();
            Console.WriteLine("Persona Agragada");
        }

        private static void InsertarPersona() {
            var p = new Persona
            {
                Identificacion = "2464",
                Nombre = "Jose",
                Apellido = "SQL",
                Genero = "M",
                Estado = 'L'
            };
            _repoPersona.AddPersona(p);
        }
    }
}
