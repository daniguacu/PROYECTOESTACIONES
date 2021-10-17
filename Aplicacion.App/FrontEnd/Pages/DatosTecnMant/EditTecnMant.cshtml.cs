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
        public static TecnicoMantenimiento tecnico = new TecnicoMantenimiento();
        public static IRepositorioTecnicoMantenimiento _repoTecnico = new RepositorioTecnicoMantenimiento(new Aplicacion.App.Persistencia.AppContext());

        public void OnGet()
        {
        }

        // POST (corto)
        public void OnPost(TecnicoMantenimiento tecnico){
            _repoTecnico.UpdateTecnicoMantenimiento(tecnico);
        }
    }
}
