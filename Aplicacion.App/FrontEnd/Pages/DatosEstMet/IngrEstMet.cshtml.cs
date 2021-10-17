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
        [BindProperty]
        public TecnicoMantenimiento tecnico {get;set;}
        public static Estacion estacion = new Estacion();
        public static IRepositorioEstacion _repoEstacion = new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioTecnicoMantenimiento _repoTecnico = new RepositorioTecnicoMantenimiento(new Aplicacion.App.Persistencia.AppContext());
        
        public void OnGet()
        {
        }

        // POST (corto)
        public void OnPost(Estacion estacion){
            _repoEstacion.AddEstacion(estacion);
            if(estacion!=null){
                tecnico=_repoTecnico.GetTecnicoMantenimiento(tecnico.Identificacion);
                if(tecnico!=null){
                    _repoEstacion.AsignarTecnico(estacion.Codigo,tecnico);
                    
                }
                

            }
        }
    }
}
