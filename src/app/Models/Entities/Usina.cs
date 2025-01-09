using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models.Entities
{
    public class Usina
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Nome { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal CapacidadeKW { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        [Required]
        [MaxLength(100)]
        public required string StatusOperacional { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Endereco { get; set; }

        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Guid CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }


        public ICollection<ProducaoDeEnergia> ProducoesDeEnergia { get; set; } = new List<ProducaoDeEnergia>();

        public Guid FonteDeEnergiaId { get; set; }
        public FonteDeEnergia FonteDeEnergia { get; set; }
    }
}
