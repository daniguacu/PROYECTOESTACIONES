using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioReporte
    {
        Reporte AddReporte(Reporte reporte);
        Reporte GetReporte(int idreporte);
        IEnumerable<Reporte> GetAllReporte();
        Reporte UpdateReporte(Reporte reporte);
        Reporte DeleteReporte(int idreporte);
        //TecnicoMantenimiento AsignarTecnico(string codigoEstacion, TecnicoMantenimiento tecnico); 
    }
}