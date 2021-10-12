using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;
using System.Text.RegularExpressions;

namespace FrontEnd.Pages
{
    public class EditEstMetModel : PageModel
    {
        public static Estacion estacion = new Estacion();
        public static IRepositorioEstacion _repoEstacion = new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());

        public void OnGet()
        {
        }

        //POST (corto)
        public void OnPost(Estacion estacion){
            _repoEstacion.UpdateEstacion(estacion);
        }

        // public void OnPost(string estacionCodigo, string estacionMunicipio, string estacionLatitud, string estacionLongitud, string estacionFechaMontaje){
        //     if (estacionCodigo == "" || estacionCodigo == null) return;
        //     Console.WriteLine("estacionCodigo > " + estacionCodigo);
        //     var estacion = new Estacion();
        //     estacion.Codigo = estacionCodigo;
        //     estacion.Municipio = estacionMunicipio;
        //     estacion.Latitud = float.Parse(Regex.Replace(estacionLatitud, @"\.", ","));
        //     estacion.Longitud = float.Parse(Regex.Replace(estacionLongitud, @"\.", ","));
        //     estacion.FechaMontaje = Convert.ToDateTime(estacionFechaMontaje);
        //     Console.WriteLine("[OnPost] > Checked");
        //     _repoEstacion.UpdateEstacion(estacion);
        // }
    }
}
