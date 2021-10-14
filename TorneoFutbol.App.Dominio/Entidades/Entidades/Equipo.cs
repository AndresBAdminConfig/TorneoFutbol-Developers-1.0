using System.ComponentModel.DataAnnotations;
namespace TorneoFutbol.App.Dominio
{
    public class Equipo
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "Maximo 20 caracteres")]
        public string Nombre { get; set; }
        
        //Relacion Equipo y Jugadores
        public System.Collections.Generic.List<Jugador> Jugadores { get; set; }
        //Relacion Equipo y Municipio
        public Municipio Municipios {get; set;}
        //Relacion Equipo y desempeño equipo
        public DesempeñoEquipo Desempeñoequipos {get; set;}

    }
}