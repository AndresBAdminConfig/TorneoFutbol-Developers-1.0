namespace TorneoFutbol.App.Dominio
{
    public class Estadio
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        //Relacion Estadio y Municipio
        public Municipio Municipios{get; set;}
        

        

    }
}