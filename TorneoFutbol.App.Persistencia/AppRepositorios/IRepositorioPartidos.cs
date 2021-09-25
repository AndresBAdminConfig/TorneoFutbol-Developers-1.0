using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia

{
    public interface IRepositorioPartidos
    {
        IEnumerable<Partidos> GetAllPartidos();
        Partidos AddPartidos(Partidos Partido);
        Partidos UpdatePartidos(Partidos Partido);
        void DeletePartidos (int idPartidos);
        Partidos GetPartidos(int idPartidos);


    }
}