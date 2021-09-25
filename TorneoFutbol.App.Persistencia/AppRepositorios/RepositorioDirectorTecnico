using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {

        private readonly AppContext _appContext;   
        public RepositorioDirectorTecnico(AppContext appContext)
        {
            _appContext = appContext;
        }

        DirectorTecnico IRepositorioDirectorTecnico.AddDirectorTecnico(DirectorTecnico directortecnico)
        {
            var directortecnicoAdicionado = _appContext.DirectorTecnico.Add(directortecnico);
            _appContext.SaveChanges();
            return directortecnicoAdicionado.Entity;
        }
        IEnumerable<DirectorTecnico> IRepositorioDirectorTecnico.GetAllDirectorTecnico()
        {
            return _appContext.DirectorTecnico;
        }
        public void DeleteDirectorTecnico(int idDirectorTecnico)
        {
            var directortecnicoEncontrado = _appContext.DirectorTecnico.Find(idDirectorTecnico);
            if (directortecnicoEncontrado == null)
                return;
            _appContext.Estadios.Remove(directortecnicoEncontrado);
            _appContext.SaveChanges();
        }
        public DirectorTecnico GetDirectorTecnico(int idDirectorTecnico)
        {
            return _appContext.DirectorTecnico.Find(idDirectorTecnico);
        }  
        public DirectorTecnico UpdateEstadio(DirectorTecnico directortecnico)
        {
            var directortecnicoEncontrado = _appContext.DirectorTecnico.Find(directortecnico.Id);
            if (directortecnicoEncontrado != null)
            {
                directortecnicoEncontrado.Nombre = directortecnico.Nombre;
                directortecnicoEncontrado.Documento = directortecnico.Documento;
                directortecnicoEncontrado.Telefono = directortecnico.Telefono;
                _appContext.SaveChanges();
            }
            return directortecnicoEncontrado;
        } 
    }
}