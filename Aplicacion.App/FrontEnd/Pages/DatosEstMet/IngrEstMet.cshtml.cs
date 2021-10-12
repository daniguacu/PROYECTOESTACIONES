using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace FrontEnd.Pages
{
    public class IngrEstMetModel : PageModel
    {
        public static Estacion estacion = new Estacion();
        public static IRepositorioEstacion _repoEstacion = new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        
        public void OnGet()
        {
        }

        // POST (corto)
        public void OnPost(Estacion estacion){
            _repoEstacion.AddEstacion(estacion);
        }
    }
}
