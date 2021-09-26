using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioArbitros
    {
        Arbitros AddGol(Arbitros arbitros);
        IEnumerable<Arbitros> GetAllArbitros();
        void DeleteArbitros(int idArbitros);
        public Arbitros UpdateArbitros(Arbitros arbitros);    
        public Arbitros GetArbitros(int idArbitros);
    }
}