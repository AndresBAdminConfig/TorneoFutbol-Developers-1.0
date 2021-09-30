using Microsoft.EntityFrameworkCore;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Jugadores> Jugador {get;set;}
        public DbSet<Arbitros> Arbitro{get; set;}
        public DbSet<DesempeñoEquipo> DesempeñoEquipos {get; set;}
        public DbSet<DirectorTecnico> DirectoresTecnicos {get; set;}
        public DbSet<equipos> equipo {get; set;}
        public DbSet<Estadio> Estadios{get; set;}
        public DbSet<Goles> Gol{get; set;}
        public DbSet<Municipio> Municipios{get; set;}
        public DbSet<Partidos> Partido{get; set;}
        public DbSet<Reporte> Reportes{get; set;}



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TorneoFutbolData");
            }
        }
    }
}