using System;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace Aplicacion.App.PresentacionC
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        private static IRepositorioDataMeteorologico _repodatos= new RepositorioDataMeteorologico(new Persistencia.AppContext());
        public static IRepositorioAdministrador _repoAdministrador= new RepositorioAdministrador(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioValidacion _repoValidacion= new RepositorioValidacion(new Aplicacion.App.Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio de Pruebas!");
            //InsertarPersona();
            Console.WriteLine("Persona Agragada");
            InsertarAdministrador();
            InsertarValidacion();
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
        private static void InsertarAdministrador()
        {
            var p=new Administrador
            {
                Identificacion=1111,
                Nombre="Claudia Elizabeth",
                Apellido="Navarro",
                Genero="Femenino",
                Estado='A',
                Password=12345,
                Rol="Admin de perfiles"
            };
            _repoAdministrador.AddAdministrador(p);
        }
        private static void InsertarValidacion()
        {
            var p=new Validacion
            {
                Val=0
            };
            _repoValidacion.AddValidacion(p);
        }

        private static void InsertarDato()
        {
            var p=new DataMeteorologico{
           FechaDato=DateTime.Today,
            Temperatura=356,
            Humedad=844,
            PresionAtmosferica=388,
            VelocidadViento=5,
            Pluviosidad= 8,
            RadiacionSolar=9
            //TipoDato=Enum.GetName(typeof(MyType),MyType.humedad)
                        
            };
            
            _repodatos.AddDato(p);
        }   
    }
}
