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
    public class IngresarReporteModel : PageModel
    {
        [BindProperty]
        public TecnicoMantenimiento tecnico {get;set;}
        [BindProperty]
        public Estacion estacion {get;set;}
        public static Reporte reporte = new Reporte();
        public static IRepositorioReporte _repoReporte = new RepositorioReporte(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioTecnicoMantenimiento _repoTecnico = new RepositorioTecnicoMantenimiento(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioEstacion _repoEstacion = new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        public void OnGet()
        {
        }

        // POST (corto)
        public void OnPost(Reporte reporte){
            _repoReporte.AddReporte(reporte);
            if(reporte!=null){
                tecnico=_repoTecnico.GetTecnicoMantenimiento(tecnico.Identificacion);
                
                if(tecnico!=null){
                    _repoTecnico.AsignarReporte(tecnico.Identificacion,reporte);
                    _repoEstacion.AsignarReporte(tecnico.Id,reporte);
                    
                }
                

            }
        }
    }
}