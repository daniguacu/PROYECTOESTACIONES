using System;

namespace Aplicacion.App.Dominio
{
    public class DataMeteorologico
    {
        public int Id{get;set;}
        public float Valor{get;set;}
        public TipoDato TipoDato{get;set;}
        public DateTime FechaDato{get;set;}
    }
}
