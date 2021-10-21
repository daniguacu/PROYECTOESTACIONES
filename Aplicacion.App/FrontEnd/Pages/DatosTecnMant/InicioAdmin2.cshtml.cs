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
     public class InicioAdmin2Model : PageModel
    {
        //public int validacion=0;
        [BindProperty]
        public Administrador administrador {get;set;}
        [TempData]
        public string nombre{get;set;}
        public static Validacion validacion=new Validacion();
        //public static Administrador administrador=new Administrador();
        public static IRepositorioAdministrador _repoAdministrador=new RepositorioAdministrador(new Aplicacion.App.Persistencia.AppContext());
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
            administrador=_repoAdministrador.GetAdministrador(administrador);
            if(administrador!=null)
            {
                nombre=administrador.Nombre+" bienvenido";
                _repoValidacion.UpdateValidacion(1,1);
                url="TecnMant";
                

            }
            else
            {
               _repoValidacion.UpdateValidacion(1,0);
               nombre="datos erroneos"; 
               
            }
            return RedirectToPage(url);
        }
    }
}