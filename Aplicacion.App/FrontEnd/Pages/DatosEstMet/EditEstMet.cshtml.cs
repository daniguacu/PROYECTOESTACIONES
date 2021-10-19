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
    public class EditEstMetModel : PageModel
    {
        [BindProperty]
        public Estacion estacion{get;set;}
       // [TempData]

        //public string codigo{get;set;}
        [TempData]

        public int numero{get;set;}
        //public static Persona persona=new Persona();
    public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost()
        {
            estacion=_repoEstacion.GetEstacion(estacion.Codigo);
            numero=estacion.Id;
            if(numero!=0){
            _repoEstacion.UpdateEstacion(estacion);
            }
        }
        
        
        
    }
}
