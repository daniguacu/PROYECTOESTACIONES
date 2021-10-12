using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioEstacion
    {
        Estacion AddEstacion(Estacion estacion);
        Estacion GetEstacion(string codigoEstacion);
        IEnumerable<Estacion> GetAllEstaciones();
        Estacion UpdateEstacion(Estacion estacion);
        Estacion DeleteEstacion(string codigoEstacion);
    }
}