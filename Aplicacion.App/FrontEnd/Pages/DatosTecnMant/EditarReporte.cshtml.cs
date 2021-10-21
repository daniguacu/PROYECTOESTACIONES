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
    public class EditarReporteModel : PageModel
    {
        [BindProperty]
        public Reporte reporte{get;set;}
        [BindProperty]
        public Estacion estacion{get;set;}
      
        [TempData]

        public int numero{get;set;}
      
    
        public static IRepositorioEstacion _repoEstacion = new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioReporte _repoReporte = new RepositorioReporte(new Aplicacion.App.Persistencia.AppContext());

        public void OnGet()
        {
        }

       
        public void OnPost(){
            Console.WriteLine("___________");
            var reporteEncontrado = _repoReporte.GetReporte(reporte.Id);
        
            numero = reporteEncontrado.Id;
            if(numero != 0) {
                
                _repoReporte.UpdateReporte(reporte);
            }
        }
    }
}
