using System.ComponentModel.DataAnnotations;
namespace TorneoFutbol.App.Dominio
{
    public class DirectorTecnico
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
    
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "Maximo 20 caracteres")]
        public string Nombre { get; set; }
       
        [Required(ErrorMessage = "El documento es obligatorio")]
        [StringLength(15, ErrorMessage = "Maximo 15 caracteres")]
        public string Documento { get; set; }
        
        [Required(ErrorMessage = "El telefono es obligatorio")]
        [StringLength(15, ErrorMessage = "Maximo 15 caracteres")]
        public string Telefono { get; set; }        
    }
}