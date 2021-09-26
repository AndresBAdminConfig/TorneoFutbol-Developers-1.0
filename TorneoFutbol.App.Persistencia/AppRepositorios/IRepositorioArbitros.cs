using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioArbitros
    {
        Arbitros AddArbitros(Arbitros arbitros);
        IEnumerable<Arbitros> GetAllArbitros();
        void DeleteArbitros(int idArbitros);
        Arbitros UpdateArbitros(Arbitros arbitros);    
        Arbitros GetArbitros(int idArbitros);
    }
}