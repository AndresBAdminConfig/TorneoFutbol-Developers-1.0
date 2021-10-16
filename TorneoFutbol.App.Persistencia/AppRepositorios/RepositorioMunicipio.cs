using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {

        private readonly AppContext _appContext = new AppContext();   
        
        Municipio IRepositorioMunicipio.AddMunicipio(Municipio municipio)
        {
            var MunicipioAdicionado = _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return MunicipioAdicionado.Entity;
        }
        IEnumerable<Municipio> IRepositorioMunicipio.GetAllMunicipio()
        {
            return _appContext.Municipios;
        }
        public void DeleteMunicipio(int idMunicipio)
        {
            var MunicipioEncontrado = _appContext.Municipios.Find(idMunicipio);
            if (MunicipioEncontrado == null)
                return;
            _appContext.Municipios.Remove(MunicipioEncontrado);
            _appContext.SaveChanges();
        }
        public Municipio GetMunicipio(int idMunicipio)
        {
            return _appContext.Municipios.Find(idMunicipio);
        }  
        public Municipio UpdateMunicipio(Municipio municipio)
        {
            var MunicipioEncontrado = _appContext.Municipios.Find(municipio.Id);
            if (MunicipioEncontrado != null)
            {
                MunicipioEncontrado.Nombre = municipio.Nombre;
                _appContext.SaveChanges();
            }
            return MunicipioEncontrado;
        } 
        
        
    }
}