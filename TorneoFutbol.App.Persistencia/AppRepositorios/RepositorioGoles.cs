using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioGoles : IRepositorioGoles
    {
        
        private readonly AppContext _appContext;
        public RepositorioGoles(AppContext appContext)
        {
            _appContext = appContext;
        }

        Goles IRepositorioGoles.AddGoles(Goles goles)
        {
            var golesAdicionado = _appContext.Gol.Add(goles);
            _appContext.SaveChanges();
            return golesAdicionado.Entity;
        }
        IEnumerable<Goles> IRepositorioGoles.GetAllGoles()
        {
            return _appContext.Gol;
        }
        public void DeleteGoles(int idGoles)
        {
            var GolesEncontrado = _appContext.Gol.Find(idGoles);
            if (GolesEncontrado == null)
                return;
            _appContext.Gol.Remove(GolesEncontrado);
            _appContext.SaveChanges();
        }
        public Goles GetGoles(int idGoles)
        {
            return _appContext.Gol.Find(idGoles);
        } 
        public Goles UpdateGoles(Goles goles)
        {
            var GolesEncontrado = _appContext.Gol.Find(goles.Id);
            if (GolesEncontrado != null)
            {
                GolesEncontrado.MinutoGol=goles.MinutoGol;
                GolesEncontrado.Jugadores=goles.Jugadores;
                
                _appContext.SaveChanges();
            }
            return GolesEncontrado;
        }
    }
}