using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models.Entities
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Nome { get; set; }

        [Required]
        [MaxLength(20)]
        public required string CpfCnpj { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public ICollection<Usina> Usinas { get; set; } = new List<Usina>();
    }
}