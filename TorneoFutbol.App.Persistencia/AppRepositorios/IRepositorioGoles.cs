using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioGoles
    {
        Goles AddGoles(Goles goles);
        IEnumerable<Goles> GetAllGoles();
        void DeleteGoles(int idGoles);
        Goles UpdateGoles(Goles goles);    
        Goles GetGoles(int idGoles);
    }
}