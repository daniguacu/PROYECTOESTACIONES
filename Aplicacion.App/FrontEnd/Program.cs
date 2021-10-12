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
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

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
                Valor=352
                //TipoDato=Enum.GetName(typeof(MyType),MyType.humedad)
            };
            _repodatos.AddDato(p);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
