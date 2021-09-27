using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioPartidos : IRepositorioPartidos
    {
        private readonly AppContext _appContext;
        public RepositorioPartidos(AppContext appContext)
        {
            _appContext = appContext;
        }

        Partidos AddPartidos(Partidos Partido)
        {
            var PartidosAdicionado = _appContext.Partido.Add(Partido);
            _appContext.SaveChanges();
            return PartidosAdicionado.Entity;
        }
        IEnumerable<Partidos> IRepositorioPartidos.GetAllPartidos()
        {
            return _appContext.Partido;
        }
        public void DeletePartidos(int idPartidos)
        {
            var PartidosEncontrado = _appContext.Partido.Find(idPartidos);
            if (PartidosEncontrado == null)
                return;
            _appContext.Partido.Remove(PartidosEncontrado);
            _appContext.SaveChanges();
        }
        public Partidos GetPartidos(int idPartidos)
        {
            return _appContext.Partido.Find(idPartidos);
        } 
        public Partidos UpdatePartidos(Partidos Partido)
        {
            var PartidosEncontrado = _appContext.Partido.Find(Partido.Id);
            if (PartidosEncontrado != null)
            {
                PartidosEncontrado.FechaHora=Partido.FechaHora;
                PartidosEncontrado.EquipoLocal=Partido.EquipoLocal;
                PartidosEncontrado.MarcadorFinal=Partido.MarcadorFinal;
                PartidosEncontrado.EquipoVisitante=Partido.EquipoVisitante;
                PartidosEncontrado.MarcadorFinal=Partido.MarcadorFinal;
                PartidosEncontrado.Colegio=Partido.Colegio;
                
                _appContext.SaveChanges();
            }
            return PartidosEncontrado;
        }

        Partidos IRepositorioPartidos.AddPartidos(Partidos Partido)
        {
            throw new System.NotImplementedException();
        }
    }
}