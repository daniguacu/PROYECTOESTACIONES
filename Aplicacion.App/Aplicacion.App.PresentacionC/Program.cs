using System;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace Aplicacion.App.PresentacionC
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        private static IRepositorioDataMeteorologico _repodatos= new RepositorioDataMeteorologico(new Persistencia.AppContext());
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
        private static void InsertarDato()
        {
            var p=new DataMeteorologico{
           FechaDato=DateTime.Today,
            Valor=356
            //TipoDato=Enum.GetName(typeof(MyType),MyType.humedad)
                        
            };
            
            _repodatos.AddDato(p);
        }   
    }
}
