namespace TorneoFutbol.App.Dominio
{
    public class Reporte
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        public string MarcadorFinal { get; set; }
        public string TarjetasAmarillas { get; set; }
        public string TarjetasRojas { get; set; }
        //Relacion Reporte y Goles
        public System.Collections.Generic.List<Gol> Goles { get; set; }
        //Relacion Reporte y Partido
        public Partido  Partidos { get; set; }
        

    }
}