using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioDesempeñoEquipos : IRepositorioDesempeñoEquipos
    {

        private readonly AppContext _appContext;
        public RepositorioDesempeñoEquipos(AppContext appContext)
        {
            _appContext = appContext;
        }

        DesempeñoEquipos IRepositorioDesempeñoEquipos.AddDesempeñoEquipos(DesempeñoEquipos Desempeño)
        {
            var DesempeñoEquiposAdicionado = _appContext.DesempeñoEquipos.Add(Desempeño);
            _appContext.SaveChanges();
            return DesempeñoEquiposAdicionado.Entity;
        }
        IEnumerable<DesempeñoEquipos> IRepositorioDesempeñoEquipos.GetAllDesempeñoEquipos()
        {
            return _appContext.DesempeñoEquipos;
        }
        public void DeleteDesempeñoEquipos(int idDesempeño)
        {
            var DesempeñoEncontrado = _appContext.DesempeñoEquipos.Find(idDesempeño);
            if (DesempeñoEncontrado == null)
                return;
            _appContext.DesempeñoEquipos.Remove(DesempeñoEncontrado);
            _appContext.SaveChanges();
        }
        public DesempeñoEquipos GetDesempeñoEquipos(int idDesempeño)
        {
            return _appContext.DesempeñoEquipos.Find(idDesempeño);
        } 
        public DesempeñoEquipos UpdateDesempeñoEquipos(DesempeñoEquipos Desempeño)
        {
            var DesempeñoEncontrado = _appContext.DesempeñoEquipos.Find(Desempeño.Id);
            if (DesempeñoEncontrado != null)
            {
                DesempeñoEncontrado.Cantidad_Partidos_Empatados=Desempeño.Cantidad_Partidos_Empatados;
                DesempeñoEncontrado.Cantidad_Partidos_Ganados=Desempeño.Cantidad_Partidos_Ganados;
                DesempeñoEncontrado.Cantidad_Partidos_Jugados=Desempeño.Cantidad_Partidos_Jugados;
                _appContext.SaveChanges();
            }
            return DesempeñoEncontrado;
        }
    }
}