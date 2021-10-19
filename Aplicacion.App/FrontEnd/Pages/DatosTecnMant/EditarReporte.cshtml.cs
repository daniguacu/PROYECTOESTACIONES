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
    public class EditarReporteMetModel : PageModel
    {
        [BindProperty]
        public Reporte reporte{get;set;}
       // [TempData]

        //public string codigo{get;set;}
        [TempData]

        public int numero{get;set;}
        //public static Persona persona=new Persona();
    public static IRepositorioReporte _repoReporte=new RepositorioReporte(new Aplicacion.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost()
        {
            reporte=_repoReporte.GetReporte(reporte.Id);
            numero=reporte.Id;
            if(numero!=0){
            _repoReporte.UpdateReporte(reporte);
            }
        }
        
        
        
    }
}