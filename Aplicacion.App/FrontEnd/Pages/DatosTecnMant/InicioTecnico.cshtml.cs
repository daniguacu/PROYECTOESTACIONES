using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace Aplicacion.App.FrontEnd
{
     public class InicioTecnicoModel : PageModel
    {
        //public int validacion=0;
        [BindProperty]
        public TecnicoMantenimiento tecnico {get;set;}
        [TempData]
        public string nombre{get;set;}
        public static Validacion validacion=new Validacion();
        //public static Administrador administrador=new Administrador();
        public static IRepositorioTecnicoMantenimiento _repoTecnico=new RepositorioTecnicoMantenimiento(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioValidacion _repoValidacion=new RepositorioValidacion(new Aplicacion.App.Persistencia.AppContext());
    
        public void OnGet()
        {
            nombre="";
        }
        public void OnPost()
        {
        }
        public IActionResult OnPostIngresar()
        {
            string url="";
            tecnico=_repoTecnico.GetTecnicoMantenimiento(tecnico.Identificacion);
            if(tecnico!=null)
            {
                
                url="Reporte";
                

            }
            else
            {
               url="";; 
               
            }
            return RedirectToPage(url);
        }
    }
}