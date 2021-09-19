namespace TorneoFutbol.App.Dominio
{
    public class Municipio
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        public string Nombre { get; set; }
        //Relacion Municipio y Equipos
        public System.Collections.Generic.List<equipos> equipos { get; set; }
        //Relacion Municipios y Estadios
        public System.Collections.Generic.List<Estadio> Estadio { get; set; }

    }
}