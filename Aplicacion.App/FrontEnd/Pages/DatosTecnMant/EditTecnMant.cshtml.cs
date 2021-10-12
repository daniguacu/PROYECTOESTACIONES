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
        public static Persona persona = new Persona();
        public static IRepositorioPersona _repoPersona = new RepositorioPersona(new Aplicacion.App.Persistencia.AppContext());

        public void OnGet()
        {
        }

        // POST (corto)
        public void OnPost(Persona persona){
            _repoPersona.UpdatePersona(persona);
        }
    }
}
