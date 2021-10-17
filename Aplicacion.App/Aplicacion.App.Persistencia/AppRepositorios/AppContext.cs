using Microsoft.EntityFrameworkCore;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Dominio.Persona> Personas{get;set;}
        public DbSet<Dominio.Estacion> Estaciones{get;set;}
        public DbSet<DataMeteorologico> DatoMeteorologico{get;set;}
        public DbSet<TecnicoMantenimiento> Tecnicos{get;set;}
        public DbSet<Dominio.Reporte> Reporte{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=aplicacion5DB");
                //conexion a azure data studio (LocalDb)\MSSQLLocalDB
            }

        }
    }
}
