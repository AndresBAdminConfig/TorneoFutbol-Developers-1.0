using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{

    public interface IRepositorioEquipo
    {
        equipos AddEquipo(equipos equipo);
        IEnumerable<equipos> GetAllEquipo();
        void DeleteEquipo(int idEquipo);
        equipos GetEquipo(int idEquipo);
        equipos UpdateEquipo(equipos equipo);

    }

}