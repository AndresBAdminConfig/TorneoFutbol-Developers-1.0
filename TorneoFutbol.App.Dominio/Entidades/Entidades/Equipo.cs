
namespace TorneoFutbol.App.Dominio
{
    public class equipos
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        public string Nombre { get; set; }
        //Relacion Equipo y Jugadores
        public System.Collections.Generic.List<Jugadores> Jugadores { get; set; }
        //Relacion Equipo y Municipio
        public Municipio Municipio {get; set;}
        //Relacion Equipo y desempeño equipo
        public DesempeñoEquipo desempeñoequipo {get; set;}

    }
}