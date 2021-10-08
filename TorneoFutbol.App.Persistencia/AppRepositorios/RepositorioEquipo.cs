using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {

        private readonly AppContext _appContext = new AppContext();   
        
        
        Equipo IRepositorioEquipo.AddEquipo(Equipo Equipos)
        {
            var equipoAdicionado = _appContext.Equipos.Add(Equipos);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity;
        }
        IEnumerable<Equipo> IRepositorioEquipo.GetAllEquipo()
        {
            return _appContext.Equipos;
        }
        public void DeleteEquipo(int idEquipo)
        {
            var EquipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if (EquipoEncontrado == null)
                return;
            _appContext.Equipos.Remove(EquipoEncontrado);
            _appContext.SaveChanges();
        }
        public Equipo GetEquipo(int idEquipo)
        {
            return _appContext.Equipos.Find(idEquipo);
        }  
        public Equipo UpdateEquipo (Equipo Equipos)
        {
            var EquipoEncontrado = _appContext.Equipos.Find(Equipos.Id);
            if (EquipoEncontrado != null)
            {
                EquipoEncontrado.Nombre = Equipos.Nombre;
                _appContext.SaveChanges();
            }
            return EquipoEncontrado;
        } 
    }
}