using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioDesempeñoEquipo
    {
        DesempeñoEquipo AddDesempeñoEquipos(DesempeñoEquipo DesempeñoEquipos);
        IEnumerable<DesempeñoEquipo> GetAllDesempeñoEquipo();
        void DeleteDesempeñoEquipos(int IdDesempeñoEquipos);
        DesempeñoEquipo GetDesempeñoEquipo(int IdDesempeñoEquipos);
        DesempeñoEquipo UpdateDesempeñoEquipo(DesempeñoEquipo DesempeñoEquipos);
    }
}