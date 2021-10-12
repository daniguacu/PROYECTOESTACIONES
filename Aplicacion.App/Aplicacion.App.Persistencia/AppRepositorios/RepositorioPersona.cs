using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public class RepositorioPersona:IRepositorioPersona
    {
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionada = _appContext.Personas.Add(persona);  
            _appContext.SaveChanges();
            Console.WriteLine("\n[AddPersona] > Completed");
            return personaAdicionada.Entity;
        }
        
        Persona IRepositorioPersona.GetPersona(string identificacionPersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Identificacion == identificacionPersona);
            return personaEncontrada;
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas(){
            return _appContext.Personas;
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Identificacion == persona.Identificacion);
            if (personaEncontrada != null) {
                //personaEncontrada.Identificacion = persona.Identificacion
                personaEncontrada.Nombre = persona.Nombre;
                personaEncontrada.Apellido = persona.Apellido;
                personaEncontrada.Genero = persona.Genero;
                personaEncontrada.Estado = persona.Estado;
                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }

        Persona IRepositorioPersona.DeletePersona(string identificacionPersona){
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Identificacion == identificacionPersona);
            if (personaEncontrada != null){
                _appContext.Personas.Remove(personaEncontrada);
                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
    }
}