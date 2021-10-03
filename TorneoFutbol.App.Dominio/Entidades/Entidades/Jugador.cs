namespace TorneoFutbol.App.Dominio
{
    public class Jugador
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public string Posicion { get; set; }
        //Relación entre Jugadores y equipos
        public Equipo Equipos{get; set;}

    }
}