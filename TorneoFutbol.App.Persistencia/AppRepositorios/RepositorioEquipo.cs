using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {

        private readonly AppContext _appContext = new AppContext();   
        
        equipos IRepositorioEquipo.AddEquipo(equipos equipo)
        {
            var equipoAdicionado = _appContext.equipo.Add(equipo);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity;
        }
        IEnumerable<equipos> IRepositorioEquipo.GetAllEquipo()
        {
            return _appContext.equipo;
        }
        public void DeleteEquipo(int idEquipo)
        {
            var EquipoEncontrado = _appContext.equipo.Find(idEquipo);
            if (EquipoEncontrado == null)
                return;
            _appContext.equipo.Remove(EquipoEncontrado);
            _appContext.SaveChanges();
        }
        public equipos GetEquipo(int idEquipo)
        {
            return _appContext.equipo.Find(idEquipo);
        }  
        public equipos UpdateEquipo (equipos equipos)
        {
            var EquipoEncontrado = _appContext.equipo.Find(equipos.Id);
            if (EquipoEncontrado != null)
            {
                EquipoEncontrado.Nombre = equipos.Nombre;
                _appContext.SaveChanges();
            }
            return EquipoEncontrado;
        } 
    }
}