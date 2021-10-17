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

        DataMeteorologico IRepositorioDataMeteorologico.AddDato(DataMeteorologico datometeorologico)
        {
            var datoAdicionada = _appContext.DatoMeteorologico.Add(datometeorologico);  
            _appContext.SaveChanges();
            return datoAdicionada.Entity;
        }
        
        DataMeteorologico IRepositorioDataMeteorologico.GetDato(int iddato)
        {
            var datoEncontrada = _appContext.DatoMeteorologico.FirstOrDefault(p => p.Id == iddato);
            return datoEncontrada;
        }

        IEnumerable<DataMeteorologico> IRepositorioDataMeteorologico.GetAllDatos(){
            return _appContext.DatoMeteorologico;
        }

        DataMeteorologico IRepositorioDataMeteorologico.UpdateDato(DataMeteorologico dato)
        {
            var datoEncontrada = _appContext.DatoMeteorologico.FirstOrDefault(p => p.Id == dato.Id);
            if (datoEncontrada != null) {
                //personaEncontrada.Identificacion = persona.Identificacion
                datoEncontrada.Temperatura = dato.Temperatura;
                datoEncontrada.Humedad = dato.Humedad;
                datoEncontrada.PresionAtmosferica = dato.PresionAtmosferica;
                datoEncontrada.VelocidadViento = dato.VelocidadViento;
                datoEncontrada.Pluviosidad = dato.Pluviosidad;
                datoEncontrada.RadiacionSolar = dato.RadiacionSolar;
                //datoEncontrada.TipoDato = dato.TipoDato;
                datoEncontrada.FechaDato = dato.FechaDato;
                //datoEncontrada.EstacionId=dato.EstacionId;
                
                _appContext.SaveChanges();
            }
            return datoEncontrada;
        }

        DataMeteorologico IRepositorioDataMeteorologico.DeleteDato(int identificacionDato){
            var personaEncontrada = _appContext.DatoMeteorologico.FirstOrDefault(p => p.Id == identificacionDato);
            if (personaEncontrada != null){
                _appContext.DatoMeteorologico.Remove(personaEncontrada);
                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
       
    }
}