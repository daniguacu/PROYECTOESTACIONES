using System;
using System.Collections.Generic;

namespace Aplicacion.App.Dominio
{
    public class Estacion
    {
        public int Id{get;set;}
        public string Codigo{get;set;}
        public string Municipio{get;set;}
        public float Latitud{get;set;}
        public float Longitud{get;set;}
        public TecnicoMantenimiento Tecnico{get;set;}
        public List<DataMeteorologico> DatosMeteorologicos{get;set;}
        public Reporte Reporte{get;set;}
        public DateTime FechaMontaje{get;set;}
    }
}
