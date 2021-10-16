using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace FrontEnd.Pages
{
    public class IngrDatosMetModel : PageModel
    {
        [BindProperty]
        public Estacion estacion{get;set;}
        [TempData]
        public int numero{get;set;}
        //public static Persona persona=new Persona();
        [TempData]
        public string codigo{get;set;}
    public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        
        public IActionResult OnPostConsultar(){
            estacion=_repoEstacion.GetEstacion(estacion.Codigo);
            if(estacion!=null){
            numero=estacion.Id;
            codigo=estacion.Codigo;
            return RedirectToPage("IngresarDatos");
            }
            else
            { return RedirectToPage("EstMet");

            }
        }
        
    }
}
