using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioDesempeñoEquipo : IRepositorioDesempeñoEquipo
    {

        private readonly AppContext _appContext = new AppContext();   
        
        DesempeñoEquipo IRepositorioDesempeñoEquipo.AddDesempeñoEquipos(DesempeñoEquipo desempeñoequipos)
        {
            var DesempeñoEquipoAdicionado = _appContext.DesempeñoEquipos.Add(desempeñoequipos);
            _appContext.SaveChanges();
            return DesempeñoEquipoAdicionado.Entity;
        }
        IEnumerable<DesempeñoEquipo> IRepositorioDesempeñoEquipo.GetAllDesempeñoEquipo()
        {
            return _appContext.DesempeñoEquipos;
        }
        public void DeleteDesempeñoEquipos(int IdDesempeñoEquipos)
        {
            var DesempeñoEquipoEncontrado = _appContext.DesempeñoEquipos.Find(IdDesempeñoEquipos);
            if (DesempeñoEquipoEncontrado == null)
                return;
            _appContext.DesempeñoEquipos.Remove(DesempeñoEquipoEncontrado);
            _appContext.SaveChanges();
        }
        public DesempeñoEquipo GetDesempeñoEquipo(int IdDesempeñoEquipos)
        {
            return _appContext.DesempeñoEquipos.Find(IdDesempeñoEquipos);
        }  
        public DesempeñoEquipo UpdateDesempeñoEquipo(DesempeñoEquipo desempeñoequipos)
        {
            var DesempeñoEquipoEncontrado = _appContext.DesempeñoEquipos.Find(desempeñoequipos.Id);
            if (DesempeñoEquipoEncontrado != null)
            {
                DesempeñoEquipoEncontrado.Cantidad_Partidos_Jugados = desempeñoequipos.Cantidad_Partidos_Jugados;
                DesempeñoEquipoEncontrado.Cantidad_Partidos_Ganados = desempeñoequipos.Cantidad_Partidos_Ganados;
                DesempeñoEquipoEncontrado.Cantidad_Partidos_Empatados = desempeñoequipos.Cantidad_Partidos_Empatados;
                DesempeñoEquipoEncontrado.GF = desempeñoequipos.GF;
                DesempeñoEquipoEncontrado.GC = desempeñoequipos.GC;
                DesempeñoEquipoEncontrado.Puntos = desempeñoequipos.Puntos;
                _appContext.SaveChanges();
            }
            return DesempeñoEquipoEncontrado;
        } 
    }
}