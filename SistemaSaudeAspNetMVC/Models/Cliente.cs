using System.ComponentModel.DataAnnotations;

namespace SistemaSaudeAspNetMVC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
