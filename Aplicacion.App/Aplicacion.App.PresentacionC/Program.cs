using System;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;
namespace Aplicacion.App.PresentacionC
{
    class Program
    {
        private static IRepositorioDataMeteorologico _repodatos= new RepositorioDataMeteorologico(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("inicio de pruebas!");
            AddDato();
            Console.WriteLine("ok");
        }

        private static void AddDato())
        {
            var p=new DataMeteorologico
            {
                Id="9252",
                Valor="356",
                TipoDato="[1,2,3,4]"
            };
            _repodatos.AddDato(p);
        }
    }
}

