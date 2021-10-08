using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{

    public interface IRepositorioEquipo
    {
        Equipo AddEquipo(Equipo Equipos);
        IEnumerable<Equipo> GetAllEquipo();
        void DeleteEquipo(int idEquipo);
        Equipo GetEquipo(int idEquipo);
        Equipo UpdateEquipo(Equipo Equipos);

    }
}