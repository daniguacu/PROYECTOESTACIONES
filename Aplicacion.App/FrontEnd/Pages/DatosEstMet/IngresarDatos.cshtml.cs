using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace FrontEnd.Pages
{
    public class IngresarDatosModel : PageModel
    {
         [BindProperty]
        public DataMeteorologico dato{get;set;}
        //[BindProperty]
        //public Estacion estacion{get;set;}
        [TempData]
        public int numero{get;set;}
       // public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
    public static IRepositorioDataMeteorologico _repodato=new RepositorioDataMeteorologico(new Aplicacion.App.Persistencia.AppContext());
       
       
           public void OnGet()
        {
            
        }
        public void OnPost(){
            
            _repodato.AddDato(dato);
            
        }
        
        
    }
}