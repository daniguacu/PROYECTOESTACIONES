using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;
using System.Text.RegularExpressions;
using System.Globalization;
namespace FrontEnd.Pages
{
    public class ConsultarReporteModel : PageModel
    {
        [BindProperty]
        public Estacion estacion{get;set;}
        [BindProperty]
        public Reporte reporte{get;set;}
       
        [TempData]

        public string Descripcion{get;set;}
        [TempData]

        public string Id{get;set;}
        
        
        
        
         public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
         //public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        

        public void OnGet()
        {
        }
        public void OnPost()
        {
            
            estacion=_repoEstacion.GetEstacion(estacion.Codigo);
                if(estacion!=null){
                    
                
                reporte=_repoEstacion.GetReporte(estacion.Codigo);
                Descripcion=reporte.Descripcion;
                Id=Convert.ToString(reporte.Id);
                
                }
            
            

            
            
        }
    }
}
            