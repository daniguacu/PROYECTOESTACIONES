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
    public class IngrDatosMetModel : PageModel
    {
       public static DataMeteorologico datometeorologico=new DataMeteorologico();
       public static IRepositorioEstacion estacionm=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioDataMeteorologico _repodatos=new RepositorioDataMeteorologico(new Aplicacion.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(DataMeteorologico datometeorologico)
        {
            //if (estacionm.GetEstacion(identEst)!=null){
                _repodatos.AddDato(datometeorologico);

            //}
            
        }
    }
}