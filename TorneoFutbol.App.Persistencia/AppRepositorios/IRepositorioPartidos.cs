using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia

{
    public interface IRepositorioPartidos
    {
        Partidos AddPartidos(Partidos Partido);
        IEnumerable<Partidos> GetAllPartidos();
        void DeletePartidos (int idPartidos);
        public Partidos UpdatePartidos(Partidos Partido);
        public Partidos GetPartidos(int idPartidos);


    }
}