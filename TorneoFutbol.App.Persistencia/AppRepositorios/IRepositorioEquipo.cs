using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{

    public interface IRepositorioEquipo
    {
        Equipos AddEquipo(Equipos equipo);
        IEnumerable<Equipos> GetAllEquipo();
        void DeleteEquipo(int idEquipo);
        Equipos GetEquipo(int idEquipo);
        Equipos UpdateEquipo(Equipos equipo);

    }

}