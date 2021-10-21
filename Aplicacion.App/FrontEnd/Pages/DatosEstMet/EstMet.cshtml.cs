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
    public class EstMetModel : PageModel
    {
        [BindProperty]
        public Validacion validacion{get;set;}

        public static IRepositorioValidacion _repoValidacion=new RepositorioValidacion(new Aplicacion.App.Persistencia.AppContext());
        public void OnGet()
        {
            //if(_repoValidacion.GetValidacion(1).Val!=1)
            //{
              //  return RedirectToPage("InicioAdmin");
            //}
            //else
            //{   
              //  _repoValidacion.UpdateValidacion(1,0);
                //return Page(); 
            //}
        }
    }
}
