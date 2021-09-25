using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioEstadios : IRepositorioEstadios
    {

        private readonly AppContext _appContext;   
        public RepositorioEstadios(AppContext appContext)
        {
            _appContext = appContext;
        }

        Estadio IRepositorioEstadios.AddEstadio(Estadio estadio)
        {
            var estadioAdicionado = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity;
        }
        IEnumerable<Estadio> IRepositorioEstadios.GetAllEstadios()
        {
            return _appContext.Estadios;
        }
        public void DeleteEstadio(int idEstadio)
        {
            var estadioEncontrado = _appContext.Estadios.Find(idEstadio);
            if (estadioEncontrado == null)
                return;
            _appContext.Estadios.Remove(estadioEncontrado);
            _appContext.SaveChanges();
        }
        public Estadio GetEstadio(int idEstadio)
        {
            return _appContext.Estadios.Find(idEstadio);
        }  
        public Estadio UpdateEstadio(Estadio estadio)
        {
            var estadioEncontrado = _appContext.Estadios.Find(estadio.Id);
            if (estadioEncontrado != null)
            {
                estadioEncontrado.Nombre = estadio.Nombre;
                estadioEncontrado.Direccion = estadio.Direccion;
                estadioEncontrado.Municipio = estadio.Municipio;
                _appContext.SaveChanges();
            }
            return estadioEncontrado;
        } 
    }
}