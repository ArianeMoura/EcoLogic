using System.ComponentModel.DataAnnotations;
using app.Models.Entities;

namespace app.Models
{
    public class EditUsinaViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Capacidade (KW) é obrigatório")]
        [Display(Name = "Capacidade (KW)")]
        public decimal CapacidadeKW { get; set; }

        [Required(ErrorMessage = "O campo Data de Início é obrigatório")]
        [Display(Name = "Data de Início")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "O campo Status Operacional é obrigatório")]
        [Display(Name = "Status Operacional")]
        public string StatusOperacional { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatório")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        [Display(Name = "Cidade")]
        public Guid CidadeId { get; set; }

        [Required(ErrorMessage = "O campo Cliente é obrigatório")]
        [Display(Name = "Cliente")]
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "O campo Tipo de Energia é obrigatório")]
        [Display(Name = "Tipo de Energia")]
        public Guid FonteDeEnergiaId { get; set; }

        // Navigation properties for dropdowns
        public List<Cidade> Cidades { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<FonteDeEnergia> FontesDeEnergia { get; set; }
    }
}
