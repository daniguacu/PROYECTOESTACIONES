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
    public class ConsultarDatosMetModel : PageModel
    {
        [BindProperty]
        public DataMeteorologico dato{get;set;}
        [BindProperty]
        public List<DataMeteorologico> datos{get;set;}
        [BindProperty]
        public Estacion estacion{get;set;}
        [TempData]

        public string Temperatura{get;set;}

        
        [TempData]

        public string Radiacion{get;set;}
        [TempData]

        public string Humedad{get;set;}

        [TempData]

        public string info{get;set;}
        [TempData]

        public string Pluviosidad{get;set;}
        [TempData]

        public int numero{get;set;}
        public static IRepositorioDataMeteorologico _repodatos=new RepositorioDataMeteorologico(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        

        public void OnGet()
        {
        }
        public void OnPost()
        {
            
            dato=_repodatos.GetDato(dato.Id);
                if(dato!=null){
                    
                    
                   Pluviosidad=Convert.ToString(dato.Pluviosidad);
                    Temperatura=Convert.ToString(dato.Temperatura);
                    Radiacion=Convert.ToString(dato.RadiacionSolar);
                    Humedad=Convert.ToString(dato.Humedad);
                
                }
            
            

            
            
        }
    }
}