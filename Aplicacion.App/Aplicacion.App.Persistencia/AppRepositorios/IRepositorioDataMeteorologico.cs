using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioDataMeteorologico
    {
        IEnumerable<DataMeteorologico> GetAllDatos();
        DataMeteorologico AddDato(DataMeteorologico datometeorologico);
        DataMeteorologico UpdateDato(DataMeteorologico dato);
        DataMeteorologico GetDato(int iddato);
        DataMeteorologico DeleteDato(int iddato);
    }
}