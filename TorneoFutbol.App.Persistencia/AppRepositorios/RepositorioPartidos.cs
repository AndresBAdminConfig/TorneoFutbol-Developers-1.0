namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioPartidos : IRepositorioPartidos
    {
        private readonly AppContext _appContext;
        public RepositorioPartidos(AppContext appContext)
        {
            _appContext - appContext;
        }

        Partidos AddPartidos(Partidos Partido);
        {
            var PartidosAdicionado = _appContext.Partidos.Add(Partido);
            _appContext.SaveChanges();
            return PartidosAdicionado.Entity;
        }

    }
}