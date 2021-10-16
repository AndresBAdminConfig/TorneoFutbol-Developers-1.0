using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
        Partido IRepositorioPartido.GetPartidos(int idPartidos)
        {
            var partido = _appContext.Partidos
                        .Where(p => p.Id == idPartidos)
                        .Include(p => p.Arbitros)
                        .FirstOrDefault();
            return partido;
        }
        public Partido UpdatePartidos(Partido partidos)
        {
            var PartidosEncontrado = _appContext.Partidos.Find(partidos.Id);
            if (PartidosEncontrado != null)
            {
                PartidosEncontrado.FechaHora = partidos.FechaHora;
                PartidosEncontrado.EquipoLocal = partidos.EquipoLocal;
                PartidosEncontrado.MarcadorFinal = partidos.MarcadorFinal;
                PartidosEncontrado.EquipoVisitante = partidos.EquipoVisitante;
                PartidosEncontrado.MarcadorFinal = partidos.MarcadorFinal;
                PartidosEncontrado.Colegio = partidos.Colegio;

                _appContext.SaveChanges();
            }
            return PartidosEncontrado;
        }
        Arbitro IRepositorioPartido.AsignarArbitro(int idPartidos, int idArbitro)
        {
            var PartidosEncontrado = _appContext.Partidos.Find(idPartidos);
            if (PartidosEncontrado != null)
            {
                var ArbitrosEncontrado = _appContext.Arbitros.Find(idArbitro);
                if (ArbitrosEncontrado != null)
                {
                    PartidosEncontrado.Arbitros = ArbitrosEncontrado;
                    _appContext.SaveChanges();
                }
                return ArbitrosEncontrado;
            }
            return null;
        }
        IEnumerable<Partido> IRepositorioPartido.SearchPartidos(string colegio)
        {
            return _appContext.Partidos
                   .Where(p => p.Colegio.Contains(colegio));
        }
    }
}