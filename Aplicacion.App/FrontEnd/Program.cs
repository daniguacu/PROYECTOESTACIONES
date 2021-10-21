using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace FrontEnd
{
    public class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Aplicacion.App.Persistencia.AppContext());
        private static IRepositorioDataMeteorologico _repodatos= new RepositorioDataMeteorologico(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioAdministrador _repoAdministrador= new RepositorioAdministrador(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioValidacion _repoValidacion= new RepositorioValidacion(new Aplicacion.App.Persistencia.AppContext());
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            InsertarAdministrador();
            InsertarValidacion();

            // Console.WriteLine("[FrontEnd] Inicio de Pruebas!");
            // InsertarPersona();
            // Console.WriteLine("[FrontEnd] Persona Agragada");
        }

        private static void InsertarPersona() {
            var p = new Persona
            {
                Identificacion = "1111",
                Nombre = "Ana",
                Apellido = "Torrices",
                Genero = "F",
                Estado = 'A'
            };
            _repoPersona.AddPersona(p);
        }
        
         private static void InsertarDato()
        {
            var p=new DataMeteorologico
            {
               
                FechaDato=DateTime.Today,
                Temperatura=356,
                Humedad=844,
                PresionAtmosferica=388,
                VelocidadViento=5,
                Pluviosidad= 8,
                RadiacionSolar=9
                //Valor=352
                //TipoDato=Enum.GetName(typeof(MyType),MyType.humedad)
            };
            _repodatos.AddDato(p);
        }
        private static void InsertarAdministrador()
        {
            var p=new Administrador
            {
                Identificacion="1111",
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

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
