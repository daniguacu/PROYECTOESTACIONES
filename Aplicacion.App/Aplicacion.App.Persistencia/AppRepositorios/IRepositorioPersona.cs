using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioPersona
    {
        Persona AddPersona(Persona persona);
        Persona GetPersona(string identificacionPersona);
        IEnumerable<Persona> GetAllPersonas();
        Persona UpdatePersona(Persona persona);
        Persona DeletePersona(string identificacionPersona);
    }
}