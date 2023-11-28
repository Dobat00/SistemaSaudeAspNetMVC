using System.ComponentModel.DataAnnotations;

namespace SistemaSaudeAspNetMVC.Models
{
    public class Medicos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Especializacao { get; set; }
        
    }
}
