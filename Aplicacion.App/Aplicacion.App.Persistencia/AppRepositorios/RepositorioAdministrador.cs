using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;
namespace Aplicacion.App.Persistencia
{
    public class RepositorioAdministrador:IRepositorioAdministrador
    {
        private readonly AppContext _appContext;
        public RepositorioAdministrador(AppContext appContext)
        {
            _appContext=appContext;
        }

        Administrador IRepositorioAdministrador.AddAdministrador(Administrador administrador)
        {
            var administradorAdicionado=_appContext.Administradores.Add(administrador);
            _appContext.SaveChanges();
            return administradorAdicionado.Entity;
        }

        Administrador IRepositorioAdministrador.UpdateAdministrador(Administrador administrador)
        {
            var administradorEncontrado=_appContext.Administradores.FirstOrDefault(p=>  p.Identificacion==administrador.Identificacion);
            if(administradorEncontrado!=null)
            {   
                administradorEncontrado.Nombre=administrador.Nombre;
                administradorEncontrado.Apellido=administrador.Apellido;
                administradorEncontrado.Estado=administrador.Estado;
                administradorEncontrado.Password=administrador.Password;
            }
            return administradorEncontrado;
        }


        void IRepositorioAdministrador.DeleteAdministradorxId(int id)
        {
            var administradorEncontrado=_appContext.Administradores.FirstOrDefault(p=>  p.Id==id);
            if(administradorEncontrado!=null)
            {
                _appContext.Administradores.Remove(administradorEncontrado);
                _appContext.SaveChanges();
            }
            //return estacionEncontrada;
        }

        void IRepositorioAdministrador.DeleteAdministrador(string identAdministrador) 
        {
           var administradorEncontrado=_appContext.Administradores.FirstOrDefault(p=>  p.Identificacion==identAdministrador);
            if(administradorEncontrado!=null)
            {
                _appContext.Administradores.Remove(administradorEncontrado);
                _appContext.SaveChanges();
            }
            
        }
        Administrador  IRepositorioAdministrador.GetAdministrador(Administrador administrador)
        {
            var administradorEncontrado=_appContext.Administradores.FirstOrDefault(p=>  p.Identificacion==administrador.Identificacion);
            if(administradorEncontrado!=null)
            {
                if(administradorEncontrado.Password==administrador.Password)
                {
                    return administradorEncontrado;
                }
            }
            return null;
        }

    }
}