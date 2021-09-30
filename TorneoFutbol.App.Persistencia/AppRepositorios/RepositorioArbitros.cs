using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioArbitros : IRepositorioArbitros
    {

        private readonly AppContext _appContext = new AppContext();
        
        Arbitros IRepositorioArbitros.AddArbitros(Arbitros arbitros)
        {
            var arbitrosAdicionado = _appContext.Arbitro.Add(arbitros);
            _appContext.SaveChanges();
            return arbitrosAdicionado.Entity;
        }
        IEnumerable<Arbitros> IRepositorioArbitros.GetAllArbitros()
        {
            return _appContext.Arbitro;
        }
        public void DeleteArbitros(int idArbitros)
        {
            var ArbitrosEncontrado = _appContext.Arbitro.Find(idArbitros);
            if (ArbitrosEncontrado == null)
                return;
            _appContext.Arbitro.Remove(ArbitrosEncontrado);
            _appContext.SaveChanges();
        }
        public Arbitros GetArbitros(int idArbitros)
        {
            return _appContext.Arbitro.Find(idArbitros);
        } 
        public Arbitros UpdateArbitros(Arbitros arbitros)
        {
            var ArbitrosEncontrado = _appContext.Arbitro.Find(arbitros.Id);
            if (ArbitrosEncontrado != null)
            {
                ArbitrosEncontrado.Nombre=arbitros.Nombre;
                ArbitrosEncontrado.Documento=arbitros.Documento;
                ArbitrosEncontrado.Telefono=arbitros.Telefono;
                ArbitrosEncontrado.Colegio=arbitros.Colegio;
                _appContext.SaveChanges();
            }
            return ArbitrosEncontrado;
        }
    }
}