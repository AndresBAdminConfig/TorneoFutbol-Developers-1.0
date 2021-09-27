using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioPartidos
    {
        Partidos AddPartidos(Partidos Partido);
        IEnumerable<Partidos> GetAllPartidos();
        void DeletePartidos (int idPartidos);
        Partidos UpdatePartidos(Partidos Partido);
        Partidos GetPartidos(int idPartidos);


    }
}