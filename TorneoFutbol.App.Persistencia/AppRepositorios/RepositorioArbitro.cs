using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {

        private readonly AppContext _appContext = new AppContext();
        
        Arbitro IRepositorioArbitro.AddArbitros(Arbitro arbitros)
        {
            var arbitrosAdicionado = _appContext.Arbitros.Add(arbitros);
            _appContext.SaveChanges();
            return arbitrosAdicionado.Entity;
        }
        IEnumerable<Arbitro> IRepositorioArbitro.GetAllArbitros()
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
        public Arbitro GetArbitros(int idArbitros)
        {
            return _appContext.Arbitros.Find(idArbitros);
        } 
        public Arbitro UpdateArbitros(Arbitro arbitros)
        {
            var ArbitrosEncontrado = _appContext.Arbitros.Find(arbitros.Id);
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