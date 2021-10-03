using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly AppContext _appContext = new AppContext();
        

        Partido IRepositorioPartido.AddPartidos(Partido partidos)
        {
            var PartidosAdicionado = _appContext.Partidos.Add(partidos);
            _appContext.SaveChanges();
            return PartidosAdicionado.Entity;
        }
        IEnumerable<Partido> IRepositorioPartido.GetAllPartidos()
        {
            return _appContext.Partidos;
        }
        public void DeletePartidos(int idPartidos)
        {
            var PartidosEncontrado = _appContext.Partidos.Find(idPartidos);
            if (PartidosEncontrado == null)
                return;
            _appContext.Partidos.Remove(PartidosEncontrado);
            _appContext.SaveChanges();
        }
        public Partido GetPartidos(int idPartidos)
        {
            return _appContext.Partidos.Find(idPartidos);
        } 
        public Partido UpdatePartidos(Partido partidos)
        {
            var PartidosEncontrado = _appContext.Partidos.Find(partidos.Id);
            if (PartidosEncontrado != null)
            {
                PartidosEncontrado.FechaHora=partidos.FechaHora;
                PartidosEncontrado.EquipoLocal=partidos.EquipoLocal;
                PartidosEncontrado.MarcadorFinal=partidos.MarcadorFinal;
                PartidosEncontrado.EquipoVisitante=partidos.EquipoVisitante;
                PartidosEncontrado.MarcadorFinal=partidos.MarcadorFinal;
                PartidosEncontrado.Colegio=partidos.Colegio;
                
                _appContext.SaveChanges();
            }
            return PartidosEncontrado;
        }

        
    }
}