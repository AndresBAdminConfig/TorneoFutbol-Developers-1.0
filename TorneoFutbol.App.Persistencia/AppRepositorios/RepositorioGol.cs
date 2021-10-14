using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioGol : IRepositorioGol
    {
        
        private readonly AppContext _appContext = new AppContext();
        
        Gol IRepositorioGol.AddGoles(Gol goles)
        {
            var golesAdicionado = _appContext.Goles.Add(goles);
            _appContext.SaveChanges();
            return golesAdicionado.Entity;
        }
        IEnumerable<Gol> IRepositorioGol.GetAllGoles()
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
        public Gol GetGoles(int idGoles)
        {
            return _appContext.Goles.Find(idGoles);
        } 
        public Gol UpdateGoles(Gol goles)
        {
            var GolesEncontrado = _appContext.Goles.Find(goles.Id);
            if (GolesEncontrado != null)
            {
                GolesEncontrado.MinutoGol=goles.MinutoGol;
                
                
                _appContext.SaveChanges();
            }
            return GolesEncontrado;
        }
    }
}