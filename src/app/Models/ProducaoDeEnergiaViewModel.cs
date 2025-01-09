using System;
using System.ComponentModel.DataAnnotations;

namespace app.Models
{
    public class ProducaoDeEnergiaViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "A Usina é obrigatória")]
        public Guid UsinaId { get; set; }

        [Required(ErrorMessage = "A Data de Produção é obrigatória")]
        [Display(Name = "Data de Produção")]
        [DataType(DataType.Date)]
        public DateTime DataProducao { get; set; }

        [Required(ErrorMessage = "A Energia Gerada é obrigatória")]
        [Display(Name = "Energia Gerada (kW)")]
        [Range(0, 9999999999.99, ErrorMessage = "A Energia Gerada deve estar entre 0 e 9999999999.99")]
        public decimal EnergiaGeradaKW { get; set; }

        [Display(Name = "Eficiência Operacional (%)")]
        [Range(0, 100, ErrorMessage = "A Eficiência Operacional deve estar entre 0 e 100")]
        public decimal? EficienciaOperacional { get; set; }
    }
}
