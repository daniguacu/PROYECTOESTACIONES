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
    public class EditTecnMantModel : PageModel
    {
        [BindProperty]
        public TecnicoMantenimiento tecnico{get;set;}
      
        [TempData]

        public int numero{get;set;}
      
    
        public static IRepositorioTecnicoMantenimiento _repoTecnico = new RepositorioTecnicoMantenimiento(new Aplicacion.App.Persistencia.AppContext());

        public void OnGet()
        {
        }

       
        public void OnPost(){
            Console.WriteLine("___________");
            var tecnicoEncontrado = _repoTecnico.GetTecnicoMantenimiento(tecnico.Identificacion);
            numero = tecnicoEncontrado.Id;
            if(numero != 0) {
                _repoTecnico.UpdateTecnicoMantenimiento(tecnico);
            }
        }
    }
}
