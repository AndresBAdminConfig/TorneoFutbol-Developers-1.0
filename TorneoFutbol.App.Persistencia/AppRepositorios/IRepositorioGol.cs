using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioGol
    {
        Gol AddGoles(Gol Goles);
        IEnumerable<Gol> GetAllGoles();
        void DeleteGoles(int idGoles);
        Gol UpdateGoles(Gol Goles);    
        Gol GetGoles(int idGoles);
    }
}