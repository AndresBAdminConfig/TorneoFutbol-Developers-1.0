namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioDesempeñoEquipos : IRepositorioDesempeñoEquipos
    {
        private readonly AppContext _appContext;
        public RepositorioDesempeñoEquipos(AppContex appContext)
        {
            _appContext - appContext;
        }

        DesempeñoEquipos AddDesempeñoEquipos(DesempeñoEquipos Desempeño);
        {
            var DesempeñoEquiposAdicionado = _appContext.DesempeñoEquipos.Add(Desempeño);
            _appContext.SaveChanges();
            return DesempeñoEquiposAdicionado.Entity;
        }

    }
}