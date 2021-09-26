using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia

{
    public interface IRepositorioDesempeñoEquipos
    {
        DesempeñoEquipos AddDesempeñoEquipos(DesempeñoEquipos Desempeño);
        IEnumerable<DesempeñoEquipos> GetAllDesempeñoEquipos();
        void DeleteDesempeñoEquipos (int idDesempeño);
        DesempeñoEquipos UpdateDesempeñoEquipos(DesempeñoEquipos Desempeño);
        DesempeñoEquipos GetDesempeñoEquipos(int idDesempeño);


    }
}