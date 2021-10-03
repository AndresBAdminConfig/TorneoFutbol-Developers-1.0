using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {

        private readonly AppContext _appContext = new AppContext();   
        
        Jugador IRepositorioJugador.AddJugadores(Jugador jugadores)
        {
            var jugadorAdicionado = _appContext.Jugadores.Add(jugadores);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }
        IEnumerable<Jugador> IRepositorioJugador.GetAllJugador()
        {
            return _appContext.Jugadores;
        }
        public void DeleteJugador(int idJugador)
        {
            var JugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (JugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(JugadorEncontrado);
            _appContext.SaveChanges();
        }
        public Jugador GetJugador(int idJugador)
        {
            return _appContext.Jugadores.Find(idJugador);
        }  
        public Jugador UpdateJugador(Jugador jugadores)
        {
            var JugadorEncontrado = _appContext.Jugadores.Find(jugadores.Id);
            if (JugadorEncontrado != null)
            {
                JugadorEncontrado.Nombre = jugadores.Nombre;
                JugadorEncontrado.Numero = jugadores.Numero;
                JugadorEncontrado.Posicion = jugadores.Posicion;
                _appContext.SaveChanges();
            }
            return JugadorEncontrado;
        } 
    }
}