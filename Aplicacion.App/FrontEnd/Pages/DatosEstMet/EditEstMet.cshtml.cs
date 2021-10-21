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
    public class EditEstMetModel : PageModel
    {
        [BindProperty]
        public Estacion estacion{get;set;}

        [BindProperty]
        public TecnicoMantenimiento tecnico{get;set;}

        [TempData]
        public int numero{get;set;}

        public static IRepositorioEstacion _repoEstacion = new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioTecnicoMantenimiento _repoTecnico = new RepositorioTecnicoMantenimiento(new Aplicacion.App.Persistencia.AppContext());
    
        public void OnGet()
        {
        }

        public void OnPost() {
            Console.WriteLine("___________");
            var estacionEncontrada = _repoEstacion.GetEstacion(estacion.Codigo);
            var tecnicoEncontrado = _repoTecnico.GetTecnicoMantenimiento(tecnico.Identificacion);
            numero = estacionEncontrada.Id;
            if(numero != 0) {
                _repoEstacion.UpdateEstacion(estacion);
                if (tecnicoEncontrado != null) {
                    _repoEstacion.AsignarTecnico(estacionEncontrada.Codigo, tecnicoEncontrado);
                }
            }
        }
        
    }
}
