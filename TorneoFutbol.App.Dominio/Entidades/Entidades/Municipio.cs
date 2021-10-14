using System.ComponentModel.DataAnnotations;
namespace TorneoFutbol.App.Dominio
{
    public class Municipio
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20,ErrorMessage = "Maximo 20 caracteres")] 
        public string Nombre { get; set; }
        //Relacion Municipio y Equipos
        public System.Collections.Generic.List<Equipo> Equipos { get; set; }
        //Relacion Municipios y Estadios
        public System.Collections.Generic.List<Estadio> Estadios { get; set; }

    }
}