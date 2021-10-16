using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public class RepositorioEstacion:IRepositorioEstacion
    {
        private readonly AppContext _appContext;

        public RepositorioEstacion(AppContext appContext)
        {
            _appContext = appContext;
        }

        Estacion IRepositorioEstacion.AddEstacion(Estacion estacion)
        {
            var estacionAdicionada = _appContext.Estaciones.Add(estacion);  
            _appContext.SaveChanges();
            Console.WriteLine("[Estacion] > Added");
            return estacionAdicionada.Entity;
        }
        
        Estacion IRepositorioEstacion.GetEstacion(string codigoEstacion)
        {
            var estacionEncontrada = _appContext.Estaciones.FirstOrDefault(p => p.Codigo == codigoEstacion);
            Console.WriteLine("[Estacion] > Readed");
            return estacionEncontrada;
            
             
        }

        IEnumerable<Estacion> IRepositorioEstacion.GetAllEstaciones(){
            return _appContext.Estaciones;
        }

        Estacion IRepositorioEstacion.UpdateEstacion(Estacion estacion)
        {
            var estacionEncontrada = _appContext.Estaciones.FirstOrDefault(p => p.Codigo == estacion.Codigo);
            if (estacionEncontrada != null) {
                estacionEncontrada.Codigo = estacion.Codigo;
                estacionEncontrada.Municipio = estacion.Municipio;
                estacionEncontrada.Latitud = estacion.Latitud;
                estacionEncontrada.Longitud = estacion.Longitud;
                estacionEncontrada.FechaMontaje = estacion.FechaMontaje;
                _appContext.SaveChanges();
                Console.WriteLine("[Estacion] > Updated");
            }
            return estacionEncontrada;
        }

        Estacion IRepositorioEstacion.DeleteEstacion(string codigoEstacion){
            var estacionEncontrada = _appContext.Estaciones.FirstOrDefault(p => p.Codigo == codigoEstacion);
            if (estacionEncontrada != null){
                _appContext.Estaciones.Remove(estacionEncontrada);
                _appContext.SaveChanges();
                Console.WriteLine("[Estacion] > Deleted");
            }
            return estacionEncontrada;
        }
    }
}