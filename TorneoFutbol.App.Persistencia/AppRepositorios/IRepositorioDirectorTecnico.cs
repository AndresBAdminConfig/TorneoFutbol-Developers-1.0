using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{

    public interface IRepositorioDirectorTecnico
    {
        DirectorTecnico AddDirectorTecnico(DirectorTecnico directortecnico);
        IEnumerable<DirectorTecnico> GetAllDirectorTecnico();
        void DeleteDirectorTecnico(int idDirectorTecnico);
        DirectorTecnico GetDirectorTecnico(int idDirectorTecnico);
        DirectorTecnico UpdateDirectorTecnico(DirectorTecnico directortecnico);

    }

}