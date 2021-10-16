using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioPartido
    {
        Partido AddPartidos(Partido partidos);
        IEnumerable<Partido> GetAllPartidos();
        void DeletePartidos(int idPartidos);
        Partido UpdatePartidos(Partido partidos);
        Partido GetPartidos(int idPartidos);
        Arbitro AsignarArbitro(int idPartidos, int idArbitro);
        IEnumerable<Partido> SearchPartidos(string colegio);

    }
    
}
