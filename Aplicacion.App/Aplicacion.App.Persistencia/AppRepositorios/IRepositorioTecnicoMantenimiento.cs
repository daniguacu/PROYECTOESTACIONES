using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion.App.Dominio;
namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioTecnicoMantenimiento
    {
        IEnumerable<TecnicoMantenimiento> GetAllTecnicos();
        TecnicoMantenimiento AddTecnicoMantenimiento(TecnicoMantenimiento tecnicoMantenimiento);
        TecnicoMantenimiento UpdateTecnicoMantenimiento(TecnicoMantenimiento tecnicoMantenimiento);
        void DeleteTecnicoMantenimientoxId(int id); 
        void DeleteTecnicoMantenimiento(string identTecnicoMantenimiento);    
        TecnicoMantenimiento GetTecnicoMantenimiento(string identTecnicoMantenimiento);
        Reporte AsignarReporte(string identTecnicoMantenimiento,Reporte reporte);
        
    }
}