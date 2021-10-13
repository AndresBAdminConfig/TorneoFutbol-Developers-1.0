using System.ComponentModel.DataAnnotations;
namespace TorneoFutbol.App.Dominio
{
    public class Estadio
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(40,ErrorMessage = "Maximo 40 caracteres")]        
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La Dirección es obligatorio")]
        [StringLength(40,ErrorMessage = "Maximo 40 caracteres")]
        public string Direccion { get; set; }
        //Relacion Estadio y Municipio
        public Municipio Municipios{get; set;}
        

        

    }
}