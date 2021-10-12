using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {

        private readonly AppContext _appContext = new AppContext();   
        
        Equipo IRepositorioEquipo.AddEquipo(Equipo  equipo)
        {
            var EquipoAdicionado = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return EquipoAdicionado.Entity;
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
        public Equipo UpdateEquipo(Equipo Equipo)
        {
            var EquipoEncontrado = _appContext.Equipos.Find(Equipo.Id);
            if (EquipoEncontrado != null)
            {
                EquipoEncontrado.Nombre = Equipo.Nombre;
                _appContext.SaveChanges();
            }
            return EquipoEncontrado;
        } 
    }
}