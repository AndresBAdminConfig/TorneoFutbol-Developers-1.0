using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioGoles
    {
        Goles AddGoles(Goles goles);
        IEnumerable<Goles> GetAllGoles();
        void DeleteGoles(int idGoles);
        public Goles UpdateGoles(Goles goles);    
        public Goles GetGoles(int idGoles);
    }
}