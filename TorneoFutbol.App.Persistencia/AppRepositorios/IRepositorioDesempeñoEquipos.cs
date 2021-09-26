using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia

{
    public interface IRepositorioDesempeñoEquipos
    {
        IEnumerable<DesempeñoEquipos> GetAllDesempeñoEquipos();
        DesempeñoEquipos AddDesempeñoEquipos(DesempeñoEquipos Desempeño);
        DesempeñoEquipos UpdateDesempeñoEquipos(DesempeñoEquipos Desempeño);
        void DeleteDesempeñoEquipos (int idDesempeño);
        DesempeñoEquipos GetDesempeñoEquipos(int idDesempeño);


    }
}