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
    public class ConsultarEstModel : PageModel
    {
        [BindProperty]
        public Estacion estacion{get;set;}
        [BindProperty]
        public TecnicoMantenimiento tecnico{get;set;}
       
        [TempData]

        public string Municipio{get;set;}
        [TempData]

        public string Latitud{get;set;}
        [TempData]

        public string Longitud{get;set;}
        [TempData]

        public string Nombre{get;set;}
        [TempData]

        public string Nom{get;set;}
        
        [TempData]

        public int numero{get;set;}
        
         public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
         //public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        

        public void OnGet()
        {
        }
        public void OnPost()
        {
            
            estacion=_repoEstacion.GetEstacion(estacion.Codigo);
                if(estacion!=null){
                    
                Municipio=estacion.Municipio;
                Latitud=Convert.ToString(estacion.Latitud);
                Longitud=Convert.ToString(estacion.Longitud);
                tecnico=_repoEstacion.GetTecnico(estacion.Codigo);
                Nom=tecnico.Nombre;
                
                }
            
            

            
            
        }
    }
}