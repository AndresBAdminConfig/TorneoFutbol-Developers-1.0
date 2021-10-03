using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioArbitro
    {
        Arbitro AddArbitros(Arbitro arbitros);
        IEnumerable<Arbitro> GetAllArbitros();
        void DeleteArbitros(int idArbitros);
        Arbitro UpdateArbitros(Arbitro arbitros);    
        Arbitro GetArbitros(int idArbitros);
    }
}