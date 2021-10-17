using System;

namespace Aplicacion.App.Dominio
{
    public class DataMeteorologico
    {
        public int Id{get;set;}
        //public TipoDato TipoDato{get;set;}
        //public float Valor{get;set;}
        public DateTime FechaDato{get;set;}
        public float Temperatura{get;set;}
        public float Humedad{get;set;}
        public float PresionAtmosferica{get;set;}
        public float VelocidadViento{get;set;}
        public float Pluviosidad{get;set;}

        public float RadiacionSolar{get;set;}


    }
}
