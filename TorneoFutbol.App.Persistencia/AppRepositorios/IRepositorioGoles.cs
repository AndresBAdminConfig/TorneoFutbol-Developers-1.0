using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioGoles
    {
        Gol AddGoles(Gol goles);
        IEnumerable<Gol> GetAllGoles();
        void DeleteGoles(int idGoles);
        Gol UpdateGoles(Gol goles);    
        Gol GetGoles(int idGoles);
    }
}