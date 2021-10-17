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
        public static IRepositorioTecnicoMantenimiento _repoTecnico = new RepositorioTecnicoMantenimiento(new Aplicacion.App.Persistencia.AppContext());

        public void OnGet()
        {
        }

        // POST (largo)
        public void OnPost(string idTecMant, string nombreTecMant, string apellidoTecMant, string generoTecMant, char estadoTecMant, string choice, int TarjetaProfesional){
            var tecnico = new TecnicoMantenimiento();
            tecnico.Identificacion = idTecMant;
            tecnico.Nombre = nombreTecMant;
            tecnico.Apellido = apellidoTecMant;
            //persona.Genero = choice;
            tecnico.Genero = generoTecMant;
            tecnico.Estado = estadoTecMant;
            tecnico.TarjetaProfesional= System.Convert.ToInt32(TarjetaProfesional);
            _repoTecnico.AddTecnicoMantenimiento(tecnico);
        }
    }
}
