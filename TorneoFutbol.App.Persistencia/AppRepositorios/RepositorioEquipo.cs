using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {

        private readonly AppContext _appContext = new AppContext();   
        
        Equipos IRepositorioEquipo.AddEquipos(Equipos equipos)
        {
            var equipoAdicionado = _appContext.Equipo.Add(equipos);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity;
        }
        IEnumerable<Equipos> IRepositorioEquipo.GetAllEquipo()
        {
            return _appContext.Equipo;
        }
        public void DeleteEquipo(int idEquipo)
        {
            var EquipoEncontrado = _appContext.Equipo.Find(idEquipo);
            if (EquipoEncontrado == null)
                return;
            _appContext.Equipo.Remove(EquipoEncontrado);
            _appContext.SaveChanges();
        }
        public Equipos GetEquipos(int idEquipo)
        {
            return _appContext.Equipo.Find(idEquipo);
        }  
        public Equipos UpdateEquipo (Equipos equipos)
        {
            var EquipoEncontrado = _appContext.Equipo.Find(equipos.Id);
            if (EquipoEncontrado != null)
            {
                EquipoEncontrado.Nombre = equipos.Nombre;
                _appContext.SaveChanges();
            }
            return EquipoEncontrado;
        } 
    }
}