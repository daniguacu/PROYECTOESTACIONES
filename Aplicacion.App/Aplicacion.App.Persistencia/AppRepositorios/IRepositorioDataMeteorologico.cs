using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioDataMeteorologico
    {
        DataMeteorologico AddDato(DataMeteorologico datometeorologico);
        DataMeteorologico GetDato(string iddato);
        IEnumerable<DataMeteorologico> GetAllDatos();
        Persona UpdateDato(DataMeteorologico dato);
        Persona DeleteDato(string iddato);
    }
}