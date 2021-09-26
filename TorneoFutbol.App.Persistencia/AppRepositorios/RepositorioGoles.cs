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
            var golesAdicionado = _appContext.Goles.Add(goles);
            _appContext.SaveChanges();
            return golesAdicionado.Entity;
        }
        IEnumerable<Goles> IRepositorioGoles.GetAllGoles()
        {
            return _appContext.Goles;
        }
        public void DeleteGoles(int idGoles)
        {
            var GolesEncontrado = _appContext.Goles.Find(idGoles);
            if (GolesEncontrado == null)
                return;
            _appContext.Goles.Remove(GolesEncontrado);
            _appContext.SaveChanges();
        }
        public Goles GetGoles(int idGoles)
        {
            return _appContext.Goles.Find(idGoles);
        } 
        public Goles UpdateGoles(Goles goles)
        {
            var GolesEncontrado = _appContext.Goles.Find(idGoles);
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