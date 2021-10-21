using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public class RepositorioReporte:IRepositorioReporte
    {
        private readonly AppContext _appContext;

        public RepositorioReporte(AppContext appContext)
        {
            _appContext = appContext;
        }

        Reporte IRepositorioReporte.AddReporte(Reporte reporte)
        {
            var reporteAdicionada = _appContext.Reporte.Add(reporte);  
            _appContext.SaveChanges();
            Console.WriteLine("\n[AddReporte] > Completed");
            return reporteAdicionada.Entity;
        }
        
        Reporte IRepositorioReporte.GetReporte(int idreporte)
        {
            var reporteEncontrada = _appContext.Reporte.FirstOrDefault(p => p.Id == idreporte);
            return reporteEncontrada;
        }

        IEnumerable<Reporte> IRepositorioReporte.GetAllReporte(){
            return _appContext.Reporte;
        }

        Reporte IRepositorioReporte.UpdateReporte(Reporte reporte)
        {
            var reporteEncontrada = _appContext.Reporte.FirstOrDefault(p => p.Id == reporte.Id);
            if (reporteEncontrada != null) {
                reporteEncontrada.Id = reporte.Id;
                reporteEncontrada.Descripcion = reporte.Descripcion;
                
                _appContext.SaveChanges();
                Console.WriteLine("[Reporte] > Updated\n" + 
                              "  {\n" + 
                              "    Descripcion: " + reporteEncontrada.Descripcion + ",\n" + 
                              
                              "  }");
            }
            return reporteEncontrada;
        }

        Reporte IRepositorioReporte.DeleteReporte(int idreporte){
            var reporteEncontrada = _appContext.Reporte.FirstOrDefault(p => p.Id == idreporte);
            if (reporteEncontrada != null){
                _appContext.Reporte.Remove(reporteEncontrada);
                _appContext.SaveChanges();
            }
            return reporteEncontrada;
        }
    }
}