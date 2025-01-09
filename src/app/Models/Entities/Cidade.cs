using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models.Entities
{
    public class Cidade
    {
       [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Name { get; set; }

        public Guid EstadoId { get; set; }
        public Estado Estado { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Usina> Usinas { get; set; } = new List<Usina>();
    }
}
