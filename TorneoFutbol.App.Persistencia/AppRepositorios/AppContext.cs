using Microsoft.EntityFrameworkCore;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Jugadores> Jugadores {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TorneoFutbolData");
            }
        }
    }
}