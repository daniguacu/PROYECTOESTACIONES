//IRepositorioPersona.cs

using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;
namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        Persona GetPersona(string identificacionpersona);
        Persona DeletePersona(string identificacionpersona);
    }
}


 // REPOSITORIO PERSONA
 
using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;
namespace Aplicacion.App.Persistencia
{
    public class RepositorioPersona: IRepositorioPersona
    {
        private readonly AppContext _appContext;
        public RepositorioPersona(AppContext appContext)
        {
            _appContext=appContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionada=_appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionada.Entity;
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada=_appContext.Personas.FirstOrDefault(p=>  p.Identificacion==persona.Identificacion);
            if(personaEncontrada!=null)
            {
                personaEncontrada.Identificacion=persona.Identificacion;
                personaEncontrada.Nombre=persona.Nombre;
                personaEncontrada.Apellido=persona.Apellido;
                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }

        Persona IRepositorioPersona.GetPersona(string identificacionpersona)
        {
            var personaEncontrada=_appContext.Personas.FirstOrDefault(p=> p.Identificacion==identificacionpersona);
            return personaEncontrada;
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }

        Persona IRepositorioPersona.DeletePersona(string identificacionpersona) 
        {
            var personaEncontrada=_appContext.Personas.FirstOrDefault(p=> p.Identificacion==identificacionpersona);
            if(personaEncontrada!=null)
            {
                _appContext.Personas.Remove(personaEncontrada);
                _appContext.SaveChanges();
            }
            return personaEncontrada; 
        }

    }
}

// APP CONTEXT

using Microsoft.EntityFrameworkCore;
using Aplicacion.App.Dominio;
namespace Aplicacion.App.Persistencia
{
    public class  AppContext:DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Estacion> Estaciones {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=nombrebasedatos");
            }
        }
    }
}



//Program.cs

using System;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;
namespace Aplicacion.App.PresentacionC
{
    class Program
    {
        private static IRepositorioPersona _repoPersona= new RepositorioPersona(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("inicio de pruebas!");
            InsertarPersona();
            Console.WriteLine("ok");
        }

        private static void InsertarPersona()
        {
            var p=new Persona
            {
                Identificacion="1234",
                Nombre="Ana",
                Apellido="Arcos",
                Genero="Femenino",
                Estado='A'

            };
            _repoPersona.AddPersona(p);
        }
    }
}


using System;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;
namespace Aplicacion.App.PresentacionC
{
    class Program
    {
        private static IRepositorioPersona _repoPersona= new RepositorioPersona(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("inicio de pruebas!");
            InsertarPersona();
            Console.WriteLine("ok");
        }

        private static void InsertarPersona()
        {
            var p=new Persona
            {
                Identificacion="9999",
                Nombre="Carlos",
                Apellido="Guerra"
                //Genero="Femenino",
                //Estado='A'
            };
            _repoPersona.AddPersona(p);
        }
    }
}



*******

