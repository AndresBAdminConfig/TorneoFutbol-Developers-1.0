using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioArbitros : IRepositorioArbitros
    {

        private readonly AppContext _appContext;
        public RepositorioArbitros(AppContext appContext)
        {
            _appContext = appContext;
        }

        Arbitros IRepositorioArbitros.AddArbitros(Arbitros arbitros)
        {
            var arbitrosAdicionado = _appContext.Arbitros.Add(arbitros);
            _appContext.SaveChanges();
            return arbitrosAdicionado.Entity;
        }
        IEnumerable<Arbitros> IRepositorioArbitros.GetAllArbitros()
        {
            return _appContext.Arbitros;
        }
        public void DeleteArbitros(int idArbitros)
        {
            var ArbitrosEncontrado = _appContext.Arbitros.Find(idArbitros);
            if (ArbitrosEncontrado == null)
                return;
            _appContext.Arbitros.Remove(ArbitrosEncontrado);
            _appContext.SaveChanges();
        }
        public Arbitros GetArbitros(int idArbitros)
        {
            return _appContext.Arbitros.Find(idArbitros);
        } 
        public Arbitros UpdateArbitros(Arbitros arbitros)
        {
            var ArbitrosEncontrado = _appContext.Arbitros.Find(idArbitros);
            if (ArbitrosEncontrado != null)
            {
                ArbitrosEncontrado.Nombre=arbitro.Nombre;
                ArbitrosEncontrado.Documento=arbitro.Documento;
                ArbitrosEncontrado.Telefono=arbitro.Telefono;
                ArbitrosEncontrado.Colegio=arbitro.Colegio;
                _appContext.SaveChanges();
            }
            return ArbitrosEncontrado;
        }
    }
}