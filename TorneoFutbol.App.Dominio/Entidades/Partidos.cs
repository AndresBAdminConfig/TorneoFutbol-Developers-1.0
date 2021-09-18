namespace TorneoFutbol.App.Dominio
{
    public class Partidos
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        public DateTime FechaHora { get; set; }
        public string EquipoLocal { get; set; }
        public int MarcadorInicial { get; set; }
        public String EquipoVisitante { get; set; }
        public int MarcadorFinal { get; set; }
        public string Colegio { get; set; }

    }
}