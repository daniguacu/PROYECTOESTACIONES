using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public class RepositorioDataMeteorologico:IRepositorioDataMeteorologico
    {
        private readonly AppContext _appContext;

        public RepositorioDataMeteorologico(AppContext appContext)
        {
            _appContext = appContext;
        }

        DataMeteorologico IRepositorioDataMeteorologico.AddDato(DataMeteorologico dato)
        {
            var datoAdicionada = _appContext.DatosMeteorologicos.Add(dato);  
            _appContext.SaveChanges();
            return datoAdicionada.Entity;
        }
        
        DataMeteorologico IRepositorioDataMeteorologico.GetDato(string iddato)
        {
            var datoEncontrada = _appContext.DatosMeteorologicos.FirstOrDefault(p => p.Id == iddato);
            return datoEncontrada;
        }

        IEnumerable<DataMeteorologico> IRepositorioDataMeteorologico.GetAllDatos(){
            return _appContext.DatosMeteorologicos;
        }

        DataMeteorologico IRepositorioDataMeteorologico.UpdateDato(DataMeteorologico dato)
        {
            var datoEncontrada = _appContext.DatosMeteorologicos.FirstOrDefault(p => p.Id == dato.Id);
            if (datoEncontrada != null) {
                //personaEncontrada.Identificacion = persona.Identificacion
                datoEncontrada.Valor = dato.Valor;
                datoEncontrada.TipoDato = dato.TipoDato;
                datoEncontrada.FechaDato = dato.FechaDato;
                
                _appContext.SaveChanges();
            }
            return datoEncontrada;
        }

        Persona IRepositorioPersona.DeletePersona(string identificacionPersona){
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Identificacion == identificacionPersona);
            if (personaEncontrada != null){
                _appContext.Personas.Remove(personaEncontrada);
                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
    }
}