using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {

        private readonly AppContext _appContext = new AppContext();   
        

        DirectorTecnico IRepositorioDirectorTecnico.AddDirectorTecnico(DirectorTecnico directortecnico)
        {
            var directortecnicoAdicionado = _appContext.DirectoresTecnicos.Add(directortecnico);
            _appContext.SaveChanges();
            return directortecnicoAdicionado.Entity;
        }
        IEnumerable<DirectorTecnico> IRepositorioDirectorTecnico.GetAllDirectorTecnico()
        {
            return _appContext.DirectoresTecnicos;
        }
        public void DeleteDirectorTecnico(int idDirectorTecnico)
        {
            var directortecnicoEncontrado = _appContext.DirectoresTecnicos.Find(idDirectorTecnico);
            if (directortecnicoEncontrado == null)
                return;
            _appContext.DirectoresTecnicos.Remove(directortecnicoEncontrado);
            _appContext.SaveChanges();
        }
        public DirectorTecnico GetDirectorTecnico(int idDirectorTecnico)
        {
            return _appContext.DirectoresTecnicos.Find(idDirectorTecnico);
        }  
        public DirectorTecnico UpdateDirectorTecnico(DirectorTecnico directortecnico)
        {
            var directortecnicoEncontrado = _appContext.DirectoresTecnicos.Find(directortecnico.Id);
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