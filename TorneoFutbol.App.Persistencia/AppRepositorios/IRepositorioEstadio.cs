using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{

    public interface IRepositorioEstadio
    {
        Estadio AddEstadio(Estadio estadio);
        IEnumerable<Estadio> GetAllEstadios();
        void DeleteEstadio(int idEstadio);
        Estadio GetEstadio(int idEstadio);
        Estadio UpdateEstadio(Estadio estadio);

    }

}