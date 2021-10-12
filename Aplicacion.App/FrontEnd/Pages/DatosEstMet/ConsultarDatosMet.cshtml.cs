using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;
using System.Text.RegularExpressions;
namespace FrontEnd.Pages
{
    public class ConsultarDatosMetModel : PageModel
    {
      
      
        public static IRepositorioDataMeteorologico _repodatos=new RepositorioDataMeteorologico(new Aplicacion.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(int iddato)
        {
            var dato=new DataMeteorologico();
            //if (estacionm.GetEstacion(identEst)!=null){
                dato.Id=iddato;
                _repodatos.GetDato(dato.Id);

            //}
            
        }
    }
}