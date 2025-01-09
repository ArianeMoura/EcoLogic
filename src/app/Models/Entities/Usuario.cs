using System.ComponentModel.DataAnnotations;

namespace app.Models.Entities
{
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Password { get; set; }

        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        
        public DateTime? UpdatedAt { get; set; }

        public string? Token { get; set; }

        public ICollection<GrupoPermissao> GruposPermissoes { get; set; } = new List<GrupoPermissao>();
    }
}
