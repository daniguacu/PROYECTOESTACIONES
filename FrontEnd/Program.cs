
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
        private static IRepositorioDataMeteorologico _repodatos= new RepositorioDataMeteorologico(new Aplicacion.App.Persistencia.AppContext());
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            AddDato();
        }
        private static void AddDato()
        {
            var p=new dato
            {
                Id="9252",
                Valor="356",
                TipoDato="[1,2,3,4]"
                
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
