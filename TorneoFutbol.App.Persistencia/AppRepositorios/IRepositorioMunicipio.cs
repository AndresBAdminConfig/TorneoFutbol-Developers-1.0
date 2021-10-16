using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioMunicipio
    {
        Municipio AddMunicipio(Municipio Municipio);
        IEnumerable<Municipio> GetAllMunicipio();
        void DeleteMunicipio(int idMunicipio);
        Municipio GetMunicipio(int idMunicipio);
        Municipio UpdateMunicipio(Municipio Municipio);
        
        
    }
}