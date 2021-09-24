namespace TorneoFutbol.App.Dominio
{
    public class Jugadores
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public string Posicion { get; set; }
        //Relación entre Jugadores y equipos
        public equipos equipos{get; set;}

    }
}