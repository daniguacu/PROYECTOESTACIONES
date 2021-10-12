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
    public class CrearTecnMantModel : PageModel
    {
        public static IRepositorioPersona _repoPersona = new RepositorioPersona(new Aplicacion.App.Persistencia.AppContext());

        public void OnGet()
        {
        }

        // POST (largo)
        public void OnPost(string idTecMant, string nombreTecMant, string apellidoTecMant, string generoTecMant, char estadoTecMant, string choice){
            var persona = new Persona();
            persona.Identificacion = idTecMant;
            persona.Nombre = nombreTecMant;
            persona.Apellido = apellidoTecMant;
            //persona.Genero = choice;
            persona.Genero = generoTecMant;
            persona.Estado = estadoTecMant;
            _repoPersona.AddPersona(persona);
        }
    }
}
