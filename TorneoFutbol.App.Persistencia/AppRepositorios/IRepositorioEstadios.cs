using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{

    public interface IRepositorioEstadios
    {
        Estadio AddEstadio(Estadio estadio);
        IEnumerable<Estadio> GetAllEstadios();
        void DeleteEstadio(int idEstadio);
        public Estadio GetEstadio(int idEstadio);
        public Estadio UpdateEstadio(Estadio estadio);

    }

}