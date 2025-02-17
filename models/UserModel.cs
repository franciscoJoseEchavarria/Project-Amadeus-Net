using System.ComponentModel.DataAnnotations;

namespace proyectoBackendAmadeusNet.models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nombre { get; set; } = string.Empty;
        [Required]
        public string correo { get; set; } = string.Empty;
        public string? contraseña { get; set; } 
        
        public UserModel (){
            
        }
        
    }

}