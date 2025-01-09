using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models.Entities
{
    public class ProducaoDeEnergia
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UsinaId { get; set; }
        public virtual Usina Usina { get; set; }

        [Required]
        public DateTime DataProducao { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal EnergiaGeradaKW { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal? EficienciaOperacional { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
