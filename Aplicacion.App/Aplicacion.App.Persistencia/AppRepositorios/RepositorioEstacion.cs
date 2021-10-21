using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


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
                estacionEncontrada.Tecnico=estacion.Tecnico;
                estacionEncontrada.Reporte=estacion.Reporte;
                _appContext.SaveChanges();
                Console.WriteLine("[Estacion] > Updated\n" + 
                              "  {\n" + 
                              "    Id: " + estacionEncontrada.Id + ",\n" + 
                              "    Codigo: " + estacionEncontrada.Codigo + ",\n" + 
                              "    Municipio: " + estacionEncontrada.Municipio + ",\n" +
                              "    Latitud: " + estacionEncontrada.Latitud + ",\n" + 
                              "    Longitud: " + estacionEncontrada.Longitud + ",\n" + 
                              "    FechaMontaje: " + estacionEncontrada.FechaMontaje + ",\n" + 
                              "  }");
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
        TecnicoMantenimiento IRepositorioEstacion.AsignarTecnico(string codigoEstacion, TecnicoMantenimiento tecnico)
        {
           var estacionEncontrada=_appContext.Estaciones.FirstOrDefault(p=> p.Codigo==codigoEstacion);
           
           //ojo con a linea 76 sia isganmos el ecnico drectamente tenemos que usar esta linea 
           if (estacionEncontrada != null)
            {
               
                estacionEncontrada.Tecnico=tecnico;
                _appContext.SaveChanges();
                
                return tecnico;
            }
            return null;

        }
        Reporte IRepositorioEstacion.AsignarReporte(int idtecnico, Reporte reporte)
        {
           var estacionEncontrada=_appContext.Estaciones.FirstOrDefault(p=> p.Tecnico.Id==idtecnico);
           
           //ojo con a linea 76 sia isganmos el ecnico drectamente tenemos que usar esta linea 
           if (estacionEncontrada != null)
            {
               
                estacionEncontrada.Reporte=reporte;
                _appContext.SaveChanges();
                
                return reporte;
            }
            return null;

        }
        
       void IRepositorioEstacion.AsignarDato(string codigoEstacion,DataMeteorologico dato)
        {
            var estacionEncontrada=_appContext.Estaciones.FirstOrDefault(p=> p.Codigo==codigoEstacion);
           if (estacionEncontrada != null)
            {
               
               estacionEncontrada.DatosMeteorologicos=new List<DataMeteorologico>
               {
                   new DataMeteorologico{Id=dato.Id,FechaDato=dato.FechaDato,Temperatura=dato.Temperatura,Humedad=dato.Humedad,PresionAtmosferica=dato.PresionAtmosferica,VelocidadViento=dato.VelocidadViento,Pluviosidad=dato.Pluviosidad},
               };
               _appContext.SaveChanges();
              
            }
        }
        TecnicoMantenimiento IRepositorioEstacion.GetTecnico(string codigoEstacion){
            var estacionEncontrada=_appContext.Estaciones.Where(p=> p.Codigo==codigoEstacion).Include(p=>p.Tecnico).FirstOrDefault();
            return estacionEncontrada.Tecnico;
        }

        List<DataMeteorologico> IRepositorioEstacion.GetDato(string codigoEstacion){
            var estacionEncontrada=_appContext.Estaciones.Where(p=> p.Codigo==codigoEstacion).Include(p=>p.DatosMeteorologicos).FirstOrDefault();
            return estacionEncontrada.DatosMeteorologicos;
        }
        Reporte IRepositorioEstacion.GetReporte(string codigoEstacion){
            var estacionEncontrada=_appContext.Estaciones.Where(p=> p.Codigo==codigoEstacion).Include(p=>p.Reporte).FirstOrDefault();
            return estacionEncontrada.Reporte;
        }
        
    }
}